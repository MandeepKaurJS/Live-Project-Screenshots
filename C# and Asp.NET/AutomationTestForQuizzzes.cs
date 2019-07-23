//Loop through all the quiz fields on by one with default values
            foreach (Quiz quizzes in quiz)
            {
                driver.FindElement(By.Name("course_id")).Click();
                new SelectElement(driver.FindElement(By.Name("course_id"))).SelectByText("W2006UPC5WaterHeaterOR_SC");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Choose a Course ID'])[1]/following::option[15]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Choose a Course ID'])[1]/following::input[1]")).Click();
                string courseid = quizzes.CourseId;
                int quizid = quizzes.QuizId;
                string status = quizzes.Status;
                int coursepage = quizzes.CoursePage;
                int coursepasspage = quizzes.PassPage;
                int coursefailpage = quizzes.FailPage;
                decimal passfailpercant = quizzes.PassFailPercent;
                string imagepath = quizzes.ImagePath;
                string comment = quizzes.Comment;
                IWebElement quiz_status = wait.Until(d => d.FindElement(By.Name("quiz_status")));
                quiz_status.Click();
                quiz_status.SendKeys(status);
                IWebElement course_page = wait.Until(d => d.FindElement(By.Name("course_page")));
                course_page.Click();
                course_page.SendKeys(coursepage.ToString());
                IWebElement course_pass_page = wait.Until(d => d.FindElement(By.Name("course_pass_page")));
                course_pass_page.Click();
                course_pass_page.SendKeys(coursepasspage.ToString());
                driver.FindElement(By.XPath("//td/table[2]")).Click();
                IWebElement course_fail_page = wait.Until(d => d.FindElement(By.Name("course_fail_page")));
                course_fail_page.Click();
                course_fail_page.SendKeys(coursefailpage.ToString());
                IWebElement pass_fail_percent = wait.Until(d => d.FindElement(By.Name("pass_fail_percent")));
                pass_fail_percent.Click();
                pass_fail_percent.SendKeys(passfailpercant.ToString());
                driver.FindElement(By.Name("quiz_image_path")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Quiz Image Path'])[1]/following::option[1]")).Click();
                driver.FindElement(By.Name("quiz_image_path")).Click();
                IWebElement quiz_comment = wait.Until(d => d.FindElement(By.Name("quiz_comment")));
                quiz_comment.Click();
                quiz_comment.SendKeys(comment="Text");
                driver.FindElement(By.Name("button_action")).Click();

                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Success:'])[1]/following::input[2]")).Click();
            