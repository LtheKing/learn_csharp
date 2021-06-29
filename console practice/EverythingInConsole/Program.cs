using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace EverythingInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dpModel = new ExProp();

            dpModel.tgl = DateTime.Now;

            Console.WriteLine("ini tipe datanya " + dpModel.tgl?.GetType().FullName);
        }

    }

    public class ExProp
    {
        public int id { get; set; }
        public Nullable<DateTime> tgl { get; set; }
    }
}
