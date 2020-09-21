using System;
using Xunit;

namespace PullReq.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            IGodClass god = new GodClass();

            var tst = "abcdefgh";
            Assert.Equal(tst, god.Echo(tst));
        }

        [Fact]
        public void Test2()
        {   
            IGodClass god = new GodClass();

            Assert.Equal(42, god.SuperMethod());
        }

        [Fact]
        public void Test3()
        {   
            IGodClass god = new GodClass();

            Assert.Null(god.Zzz());
        }
    }
}
