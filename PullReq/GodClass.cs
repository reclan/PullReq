﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PullReq
{
    public class GodClass : IGodClass
    {
        public string Echo( string arg)
        {
            return arg;
        }

        public int SuperMethod()
        {
            return 42;
        }

        public int Yyy() => 0;

        public object Zzz() => null;
    }

    public interface IGodClass
    {
        string Echo( string arg);
        int SuperMethod();


        int Yyy();
        object Zzz();

    }
}
