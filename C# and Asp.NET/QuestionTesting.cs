 //foreach quiz question
                for (int j = 0; j < quizzes.Questions.Count; j++)
                {
                    int questionId = quizzes.Questions[j].QuestionId;
                    string questionText = quizzes.Questions[j].QuestionText;
                    // we add one to this value because the portal isn't zero-based
                    int CorrectAnswerIndex = quizzes.Questions[j].CorrectAnswerIndex + 1;
                    string questStatus = quizzes.Questions[j].QuestionStatus;
                    string qType = quizzes.Questions[j].QuestionType;
                    IWebElement qstatus = wait.Until(d => d.FindElement(By.Name("q_status")));
                    qstatus.Click();
                    qstatus.SendKeys(questStatus);
                    IWebElement qtype = wait.Until(d => d.FindElement(By.Name("q_type")));
                    qtype.Click();
                    qtype.Clear();
                    qtype.SendKeys(qType = "M");
                    IWebElement qtext = wait.Until(d => d.FindElement(By.Name("q_text")));
                    qtext.Click();
                    qtext.Clear();
                    qtext.SendKeys(questionText);
                    for (int i = 0; i < quizzes.Questions[j].Answers.Count(); i++)
                    {
                        IWebElement answerText = wait.Until(d => d.FindElement(By.Name($"q_a{i + 1}")));
                        answerText.SendKeys(quizzes.Questions[j].Answers[i]);
                    }
                    IWebElement qCorrect = wait.Until(d => d.FindElement(By.Name("q_correct")));
                    qCorrect.SendKeys(CorrectAnswerIndex.ToString());
                    IWebElement qimage = wait.Until(d => d.FindElement(By.Name("q_image_path")));
                    qimage.Click();
                    IWebElement q_comment = wait.Until(d => d.FindElement(By.Name("q_comment")));
                    q_comment.Click();
                    q_comment.Clear();
                    q_comment.SendKeys("Test");
                    driver.FindElement(By.Name("button_action")).Click();
                    if (j < quizzes.Questions.Count - 1)
                    {
                        driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Success:'])[1]/following::input[2]")).Click();
                    }
                }
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Success:'])[1]/following::input[1]")).Click();
            }
            Console.WriteLine("Program has completed. !Successfully");
            return driver;
        }