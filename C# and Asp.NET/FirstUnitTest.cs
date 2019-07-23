 [TestMethod]
        public void ReadDocument_Shouldreturn_TwolinewheninputisTwo()
        {
            // arrange
            string expected = "World!";
            // act
            var result = Helper.ReadDocument(@"..\..\..\AutomateQuizInput\Docs\TextFile.txt").ToList();
            // assert
            Assert.AreEqual(expected, result[1]);
        }

        [TestMethod]
        public void InputQuizTask_ShouldReturnQuizzes()
        {
            // arrange
            Quiz quiz = new Quiz(TestAuxiliaryMethods.GetMockQuizInputData(), "4545");
            //this is new note for tets
            string str = $"Working on quiz {quiz.QuizId}";

            // act
            var x = quiz.InputQuizTask(quiz);

            // assert
            Assert.AreEqual(str, x);
        }

       