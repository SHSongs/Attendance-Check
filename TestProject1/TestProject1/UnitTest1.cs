using System.Collections.Generic;
using NUnit.Framework;


namespace AttendanceCheck
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
                "000오후 1:31", _computer.RemoveBlank(Platform.Google)[0]);
        }

        [Test]
        public void 내용삭제테스트()
        {
            Assert.AreEqual("000오후 1:31", _computer.RemoveNote(_computer.RemoveBlank(Platform.Google))[0]);
            Assert.AreEqual("11오후 1:31", _computer.RemoveNote(_computer.RemoveBlank(Platform.Google))[1]);

            List<string> ls = _computer.RemoveNote(_computer.RemoveBlank(Platform.Google));
            Assert.AreEqual("222오후 1:36", ls[ls.Count - 1]);
        }

        [Test]
        public void 날짜지우기테스트()
        {
            Assert.AreEqual("000", _computer.GetData(Platform.Google)[0]);
            Assert.AreEqual("11", _computer.GetData(Platform.Google)[1]);
        }

        [Test]
        public void 출첵안한분테스트()
        {
            Assert.AreEqual(2, _computer.FindPeopleDidNotCheckAttendance(1, 1, Platform.Google, AttendanceMathod.all).안한분.Count);
            Assert.AreEqual("333", _computer.FindPeopleDidNotCheckAttendance(1, 1, Platform.Google, AttendanceMathod.all).안한분[0]);
            Assert.AreEqual("444", _computer.FindPeopleDidNotCheckAttendance(1, 1, Platform.Google, AttendanceMathod.all).안한분[1]);
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

            Assert.AreEqual("000", _computer.GetData(Platform.Google)[1]);
        }

        [Test]
        public void 출책안한분테스트()
        {
            Assert.AreEqual(1, _computer.FindPeopleDidNotCheckAttendance(0, 2, Platform.Google, AttendanceMathod.all).안한분.Count);
            Assert.AreEqual("111", _computer.FindPeopleDidNotCheckAttendance(0, 2, Platform.Google, AttendanceMathod.all).안한분[0]);
        }
    }

    public class EBSGrade1
    {
        private Computer _computer;

        private string data = "";
        
        [Test]
        public void 데이터_전처리()
        {
            _computer = new Computer(data);


            Assert.AreEqual(
                "0*0", _computer.RemoveBlank(Platform.Ebs)[0]);

            Assert.AreEqual(
                "2020-09-08 14:34:10", _computer.RemoveBlank(Platform.Ebs)[1]);


            List<string> postdata = _computer.RemoveBlank(Platform.Ebs);
            Assert.AreEqual(
                "0*0", _computer.RemoveDate(postdata, Platform.Ebs)[0]);
            Assert.AreEqual(
                "1405 000 출석", _computer.RemoveDate(postdata, Platform.Ebs)[1]);


            Assert.AreEqual(
                "000", _computer.GetData(Platform.Ebs)[0]);
            Assert.AreEqual(
                "111", _computer.GetData(Platform.Ebs)[1]);
        }

        [Test]
        public void 출책안한분테스트()
        {
            _computer = new Computer(data);

            Assert.AreEqual(10, _computer.FindPeopleDidNotCheckAttendance(0, 3, Platform.Ebs, AttendanceMathod.all).안한분.Count);
            Assert.AreEqual("222", _computer.FindPeopleDidNotCheckAttendance(0, 3, Platform.Ebs, AttendanceMathod.all).안한분[0]);
            Assert.AreEqual("333", _computer.FindPeopleDidNotCheckAttendance(0, 3, Platform.Ebs, AttendanceMathod.all).안한분[9]);
        }
    }
}