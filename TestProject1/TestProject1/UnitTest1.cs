using System.Collections.Generic;
using NUnit.Framework;


namespace TestProject1
{

    
    public class Tests
    {
        private Computer _computer;
        [SetUp]
        public void Setup()
        {
            _computer = new Computer();
            
        }

        [Test]
        public void 기본테스트테스트()
        { 
            Assert.AreEqual(
                "파송송오후 1:31",_computer.기본처리()[0]);

        }
        [Test]
        public void 내용삭제테스트()
        {
            Assert.AreEqual("파송송오후 1:31", _computer.내용삭제()[0] );
            Assert.AreEqual( "파송송오후 1:31",_computer.내용삭제()[1]);

            List<string> ls = _computer.내용삭제();
            Assert.AreEqual( "파송송오후 1:36",ls[ls.Count-1]);
        }
        [Test]
        public void 날짜지우기테스트()
        {
            Assert.AreEqual("파송송",_computer.날짜지우기()[0]);
            Assert.AreEqual("송송파", _computer.날짜지우기()[1]);
        }
        
        [Test]
        public void 출첵안한놈테스트()
        {
            Assert.AreEqual(2,_computer.출첵_안한분_찾아내기(1,1).Count);
            Assert.AreEqual("파송송",_computer.출첵_안한분_찾아내기(1,1)[0]);
            Assert.AreEqual("소송파",_computer.출첵_안한분_찾아내기(1,1)[1]);
            

        }
    
    }
}