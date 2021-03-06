﻿using FluentGenericDao.TaskConsole.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FluentGenericDao.TaskConsole
{
    public class Program
    {
        public static Dictionary<int, AbstractInterpreter> _ActionList;
        static void Main(string[] args)
        {

            int _intOption = 1;
            _ActionList = new Dictionary<int, AbstractInterpreter>();
            _ActionList.Add(1, TaskFactory.AddTask);

            try
            {
                string option = ShowOptions(_ActionList, args);
                while (int.TryParse(option, out _intOption) == false && !_ActionList.ContainsKey(_intOption))
                {
                    Console.Clear();
                    Console.WriteLine("Please insert with one of these numeric options");
                    option = ShowOptions(_ActionList, args);
                }

                _ActionList[_intOption].Execute(args);

                if (args.Length != 0)
                    return;

                Console.WriteLine("====================================================");
                Console.WriteLine("============= PROCESSS HAS BEEN FINISHED=============");
                Console.WriteLine("====================================================");

            }
            catch (Exception oException)
            {
                Console.WriteLine("Error in {0} at {1}: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), oException.Message);
                Console.WriteLine("StackTrace: {0}", oException.StackTrace);
                Console.ReadKey();
            }

        }


        private static string ShowOptions(Dictionary<int, AbstractInterpreter> _ActionList, string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            foreach (var item in _ActionList)
                Console.WriteLine("{0}) {1}", item.Key, item.Value.Description());

            var hasArguments = args.Length != 0;

            return hasArguments ? args[0] : Console.ReadLine();
        }





    }
}
