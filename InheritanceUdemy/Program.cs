using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2243554#content
namespace InheritanceUdemy
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}