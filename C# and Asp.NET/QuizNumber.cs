public Quiz(IEnumerable<string> quizData, string courseId)
        {
            List<string> quizDataList = quizData.ToList(); 
            CourseId = courseId;
            // this will need to be validated
           var firstLine = quizDataList[0];
            
            string[] number = Regex.Split(firstLine, @"\D+");
            foreach(string value in number)
            {
                if(!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    //Console.WriteLine("number:{0}", i);

                    QuizId = Convert.ToInt32(i);
                }
            }