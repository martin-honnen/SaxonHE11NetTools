using System.Diagnostics;
using System.Reflection;
using net.sf.saxon;

namespace net.liberty_development.saxontools.SaxonXslt
{
    public class Xslt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"SaxonHENetXslt 11.7.0 on .NET {Environment.Version} {Environment.OSVersion}");
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver"));
            //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver_data"));

            Transform.main(args);

            stopWatch.Stop();

            Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");
        }
    }
}