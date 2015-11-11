using System;
using System.ComponentModel;
using System.Net;

namespace ForumPrograms {

    class BackgroundTasks {

        void worker_DoWork(object sender, DoWorkEventArgs e) {
            string url = (string)e.Argument;
            string pageText;
            using (WebClient client = new WebClient()) {
                pageText = client.DownloadString(url);
            }
            e.Result = new string[] { url, pageText };
        }
        
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            string[] r = (string[])e.Result;
            Console.WriteLine("Downloaded URL {0} - Size:{1} ", r[0], r[1].ToString().Length);
        }

        void GetWebPageAsync(string url) {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync(url);
        }

        private void Run() {
            GetWebPageAsync("http://google.com");
            GetWebPageAsync("http://microsoft.com");
            GetWebPageAsync("https://ecampus.phoenix.edu/");
            Console.WriteLine("Invoked all three downloads");
        }

        static void Main(string[] args) {
            BackgroundTasks program = new BackgroundTasks();
            program.Run();
            Console.ReadKey();
        }
    }
}
