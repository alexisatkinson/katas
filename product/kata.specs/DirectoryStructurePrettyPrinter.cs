using System;
using System.Diagnostics;
using System.IO;
using developwithpassion.specifications.rhino;
using Machine.Specifications;
using nothinbutdotnetstore;

namespace kata.specs
{
    public abstract class concern : Observes<DirectoryStructurePrettyPrinter>
    {
        
    }

    

//    public interface Display
//    {
//        void Writeline();
//    }

    [Subject(typeof(DirectoryStructurePrettyPrinter))]
    public class when_given_an_invalid_directory_string : concern
    {
        Because of = () => catch_exception(() => sut.PrettyPrint(@"Z://invalidpath"));

        It should_throw_an_invalid_argument_exception = () => exception_thrown_by_the_sut.ShouldBeOfType<ArgumentException>();
        static DirectoryStructurePrettyPrinter directoryStructurePrettyPrinter;
    }

    [Subject(typeof (DirectoryStructurePrettyPrinter))]
    public class when_given_a_valid_directory_string
    {
        Establish context = () => {  };

        Because of = () => { };

        It should_ = () => { };
    }

    



    public class DirectoryStructurePrettyPrinter
    {
        public void PrettyPrint(string directoryPath)
        {
            System.IO.DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if(!directoryInfo.Exists) throw new ArgumentException();
        }
    }
}