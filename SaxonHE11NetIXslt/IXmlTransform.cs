using System.Diagnostics;
using net.sf.saxon;
using org.nineml.coffeesacks;

namespace net.liberty_development.saxontools.SaxonIXslt
{
    public class IXmlTransform : Transform
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"SaxonHENetIXslt 11.6.8.9 on .NET {Environment.Version} {Environment.OSVersion}");
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver"));
            //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver_data"));

            var invisibleXmlTransformer = new IXmlTransform();

            invisibleXmlTransformer.doTransform(args);

            stopWatch.Stop();

            Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");
        }


        protected override void initializeConfiguration(Configuration config)
        {
            var coffeeSacksRegister = new RegisterCoffeeSacks();

            coffeeSacksRegister.initialize(config);
        }

    }
}