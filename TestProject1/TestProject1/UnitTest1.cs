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
            string data = "";

            _computer = new Computer(data);
        }

        [Test]
        public void 기본테스트테스트()
        { 
            Assert.AreEqual(
                " 1:31",_computer.기본처리(Platform.Google)[0]);
        }
        [Test]
        public void 내용삭제테스트()
        {
            Assert.AreEqual(" 1:31", _computer.내용삭제(_computer.기본처리(Platform.Google))[0] );
            Assert.AreEqual( " 1:31",_computer.내용삭제(_computer.기본처리(Platform.Google))[1]);

            List<string> ls = _computer.내용삭제(_computer.기본처리(Platform.Google));
            Assert.AreEqual( " 1:36",ls[ls.Count-1]);
        }
        [Test]
        public void 날짜지우기테스트()
        {
            Assert.AreEqual("",_computer.GetData(Platform.Google)[0]);
            Assert.AreEqual("", _computer.GetData(Platform.Google)[1]);
        }
        
        [Test]
        public void 출첵안한분테스트()
        {
            Assert.AreEqual(2,_computer.출첵_안한분_찾아내기(1,1,Platform.Google).Count);
            Assert.AreEqual("",_computer.출첵_안한분_찾아내기(1,1,Platform.Google)[0]);
            Assert.AreEqual("",_computer.출첵_안한분_찾아내기(1,1,Platform.Google)[1]);
            
        }
    
    }

    public class Grade1Test
    {
        private Computer _computer;
        [Test]
        public void 데이터_전처리()
        {
            string data = "";

            _computer = new Computer(data);

            Assert.AreEqual("", _computer.GetData(Platform.Google)[1]);
        }

        [Test]
        public void 출책안한분테스트()
        {
            Assert.AreEqual(1,_computer.출첵_안한분_찾아내기(0,2, Platform.Google).Count);
            Assert.AreEqual("",_computer.출첵_안한분_찾아내기(0,2, Platform.Google)[0]);
        }
    }

    public class EBSGrade1
    {
        private Computer _computer;
        string data =
            "";

        [Test]
        public void 데이터_전처리()
        {

            _computer = new Computer(data);
            
            
            Assert.AreEqual(
                "", _computer.기본처리(Platform.Ebs)[0]);
            
            Assert.AreEqual(
                "2020-09-08 14:34:10", _computer.기본처리(Platform.Ebs)[1]);
            
            
            List<string> postdata = _computer.기본처리(Platform.Ebs);
            Assert.AreEqual(
                "", _computer.날짜지우기(postdata,Platform.Ebs)[0]);
            Assert.AreEqual(
                " 출석", _computer.날짜지우기(postdata,Platform.Ebs)[1]);

            
            Assert.AreEqual(
                "", _computer.GetData(Platform.Ebs)[0]);
            Assert.AreEqual(
                "", _computer.GetData(Platform.Ebs)[1]);

        }
        
        [Test]
        public void 출책안한분테스트()
        {
            _computer = new Computer(data);

            Assert.AreEqual(10,_computer.출첵_안한분_찾아내기(0,3, Platform.Ebs).Count);
            Assert.AreEqual("",_computer.출첵_안한분_찾아내기(0,3, Platform.Ebs)[0]);
            Assert.AreEqual("",_computer.출첵_안한분_찾아내기(0,3, Platform.Ebs)[9]);
        }
    }
}