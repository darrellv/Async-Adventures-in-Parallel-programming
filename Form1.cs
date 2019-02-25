using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDev_ClientTemplate
{
    public partial class Form1 : Form
    {
        List<SubmitResult> srList;
        List<SubmitResult> advancedSrList;

        AppSubmitService.AppSubmitSimulationServiceClient wref;
        public Form1()
        {
            InitializeComponent();
            wref = new AppSubmitService.AppSubmitSimulationServiceClient();
        }

        private void btn_ProcessSync_Click(object sender, EventArgs e)
        {
            try
            {
                int TotalTime = 0;
                List<SubmitResult> submitResultList = new List<SubmitResult>();
                int processTimeMs = System.Convert.ToInt32(tb_ProcessTimeMs.Text);
                int AppCount = System.Convert.ToInt32(tb_AppCount.Text);
                for (int a = 0; a < AppCount; a++)
                {
                    SubmitResult SR = new SubmitResult();
                    Stopwatch SW = new Stopwatch();
                    SW.Start();

                    SR.PolicyNum = wref.AppSubmitSimulator(processTimeMs);
                    SW.Stop();
                    submitResultList.Add(SR);
                    dgv_SyncResults.DataSource = null;  //Reset the DGV to force next call to reset bindings. (Cheap Trick to force update)
                    dgv_SyncResults.DataSource = submitResultList;

                    SR.ProcessTimeMs = (int)SW.ElapsedMilliseconds;
                    TotalTime += SR.ProcessTimeMs;
                    pb_Sync.Value = ((a + 1) * 100 / AppCount);
                }
                //Populate the Total Time Window
                tb_SyncTotalTime.Text = TotalTime.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.ToString());
            }
        }

        private async void btn_ParallelAsync_Click(object sender, EventArgs e)
        {
            try
            {
                int TotalTime = 0;
                int processTimeMs = System.Convert.ToInt32(tb_ProcessTimeMs.Text);
                srList = new List<SubmitResult>();
                Stopwatch SW = new Stopwatch();
                SW.Start();

                await SubmitAppParallelAsync(processTimeMs);

                SW.Stop();
                TotalTime = (int)SW.ElapsedMilliseconds;

                dgv_ParallelAsyncResult.DataSource = srList;

                tb_ParallelAsync.Text = TotalTime.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.ToString());
            }
        }

        private async Task SubmitAppParallelAsync(int processTimeMs)
        {
            // call the webservice
            int AppCount = System.Convert.ToInt32(tb_AppCount.Text);
            List<Task<string>> tasks = new List<Task<string>>();
            Stopwatch SW = new Stopwatch();
            SW.Start();

            for (int a = 0; a < AppCount; a++)
            {

                SubmitResult SR = new SubmitResult();

                Stopwatch taskSw = new Stopwatch();
                taskSw.Start();
                SR.PolicyNum = await Task.Run(() => wref.AppSubmitSimulator(processTimeMs));
                //tasks.Add(Task.Run(() => wref.AppSubmitSimulator(processTimeMs)));

                taskSw.Stop();
                SR.ProcessTimeMs = (int)taskSw.ElapsedMilliseconds;
                srList.Add(SR);
                pb_ParallelAsync.Value = ((a + 1) * 100 / AppCount);

            }

            // this line waits until all tasks are complete, then puts them in results
            //var taskResults = await Task.WhenAll(tasks);

            SW.Stop();

            //foreach (var t in taskResults)
            //{

            //    SubmitResult SR = new SubmitResult();
            //    SR.ProcessTimeMs = (int)SW.ElapsedMilliseconds / AppCount;
            //    SR.PolicyNum = t;
            //    srList.Add(SR);
            //}
        }

        private async void btn_ProcessAsync_Click(object sender, EventArgs e)
        {
            try
            {
                int TotalTime = 0;
                List<SubmitResult> submitResultList = new List<SubmitResult>();
                int processTimeMs = System.Convert.ToInt32(tb_ProcessTimeMs.Text);
                int AppCount = System.Convert.ToInt32(tb_AppCount.Text);
                for (int a = 0; a < AppCount; a++)
                {
                    SubmitResult SR = new SubmitResult();
                    Stopwatch SW = new Stopwatch();
                    SW.Start();

                    SR = await Task.Run(() => SubmitAppAsync(processTimeMs));

                    SW.Stop();

                    submitResultList.Add(SR);
                    dgv_AsyncResult.DataSource = null;  //Reset the DGV to force next call to reset bindings. (Cheap Trick to force update)
                    dgv_AsyncResult.DataSource = submitResultList;
                    SR.ProcessTimeMs = (int)SW.ElapsedMilliseconds;
                    TotalTime += SR.ProcessTimeMs;
                    pb_Async.Value = ((a + 1) * 100 / AppCount);
                }
                //Populate the Total Time Window
                tb_AsyncTotalTime.Text = TotalTime.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.ToString());
            }
        }

        private SubmitResult SubmitAppAsync(int processTimeMs)
        {
            SubmitResult sr = new SubmitResult();
            // call web service
            sr.PolicyNum = wref.AppSubmitSimulator(processTimeMs);
            return sr;
        }

        // event handler for when progress changed is called:
        private void ReportProgress(object sender, ReportProgressModel e)
        {
            // update percent complete
            pb_AdvancedParallelAsync.Value = e.PercentComplete;

            // note that the following two lines add overhead, and will slow the process, but enable the user to see progress.
            // on about 100 transactions, the overhead adds about 1 second.  try it and see what you get..
            dgv_AdvancedOutput.DataSource = null;
            dgv_AdvancedOutput.DataSource = e.AppsProcessed;

        }

        private async void btn_AdvancedParalleAsync_Click(object sender, EventArgs e)
        {
            Progress<ReportProgressModel> progress = new Progress<ReportProgressModel>();
            tb_AdvancedTotalTime.Text = "";
            progress.ProgressChanged += ReportProgress;
            Stopwatch sw2 = new Stopwatch();
            List<SubmitResult> results = new List<SubmitResult>();
            results.Clear();
            sw2.Start();
            // Call the async method to run this in parallel, but with the update overhead.
            results = await RunAdvancedParalleAsync(progress);
            sw2.Stop();
            tb_AdvancedTotalTime.Text = sw2.ElapsedMilliseconds.ToString();

        }

        private async Task<List<SubmitResult>> RunAdvancedParalleAsync(IProgress<ReportProgressModel> progress)
        {
            List<SubmitResult> output = new List<SubmitResult>();
            int processTimeMs = System.Convert.ToInt32(tb_AdvancedProcessTime.Text);
            int appCount = System.Convert.ToInt32(tb_AdvancedAppsToSubmit.Text);
            ReportProgressModel report = new ReportProgressModel();

            for (int a = 0; a < appCount; a++)
            {
                SubmitResult sr = new SubmitResult();
                // task just returns policynumber (string) at this point.
                Stopwatch swAdvanced = new Stopwatch();
                swAdvanced.Start();

                sr.PolicyNum = await (Task.Run(() => wref.AppSubmitSimulator(processTimeMs)));

                swAdvanced.Stop();
                sr.ProcessTimeMs = (int)swAdvanced.ElapsedMilliseconds;
                output.Add(sr);

                report.PercentComplete = ((a + 1) * 100 / appCount);
                report.AppsProcessed = output;

                progress.Report(report);

            }

            return output;
        }
    }
}
