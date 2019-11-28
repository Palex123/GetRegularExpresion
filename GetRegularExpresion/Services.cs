using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace GetRegularExpresion
{
    public static class Services
    {
        public static async Task<int> DownloadAndCountBytesAsync(string url, CancellationToken token=new CancellationToken())
        {
            await Task.Delay(TimeSpan.FromSeconds(5), token).ConfigureAwait(false);
            var client = new HttpClient();
            using (var response=await client.GetAsync(url,token).ConfigureAwait(false))
            {
                var data = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                return data.Length;
            }
        }

        public static async Task<string> DownloadStringAsync(string url, CancellationToken token=new CancellationToken())
        {
            await Task.Delay(TimeSpan.FromSeconds(5), token).ConfigureAwait(false);
            var client = new HttpClient();
            using (var response = await client.GetAsync(url, token).ConfigureAwait(false))
            {
                var data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return data;
            }
        }
    }
}
