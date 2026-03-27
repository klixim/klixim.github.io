using Practice_Task_6.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Practice_Task_6.Services
{
    public class XmlLoader
    {
        private string filePath;

        public XmlLoader(string path)
        {
            filePath = path;
        }

        public List<Theme> LoadThemes()
        {
            var themes = new List<Theme>();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNodeList themeNodes = doc.SelectNodes("/inventions/theme");
                if (themeNodes != null)
                {
                    foreach (XmlNode themeNode in themeNodes)
                    {
                        Theme theme = new Theme();
                        if (themeNode.Attributes["name"] != null)
                        {
                            theme.Name = themeNode.Attributes["name"].Value;
                        }

                        XmlNodeList levelNodes = themeNode.SelectNodes("level");
                        if (levelNodes != null)
                        {
                            foreach (XmlNode levelNode in levelNodes)
                            {
                                Level level = new Level();
                                if (levelNode.Attributes["difficulty"] != null)
                                {
                                    level.Difficulty = int.Parse(levelNode.Attributes["difficulty"].Value);
                                }

                                XmlNodeList questionNodes = levelNode.SelectNodes("question");
                                if (questionNodes != null)
                                {
                                    foreach (XmlNode qNode in questionNodes)
                                    {
                                        InventionQuestion question = new InventionQuestion();

                                        XmlNode inventionNode = qNode.SelectSingleNode("invention");
                                        if (inventionNode != null)
                                        {
                                            question.InventionName = inventionNode.InnerText;
                                        }

                                        XmlNode imageNode = qNode.SelectSingleNode("image");
                                        if (imageNode != null)
                                        {
                                            question.ImagePath = imageNode.InnerText;
                                        }

                                        XmlNode hintNode = qNode.SelectSingleNode("hint");
                                        if (hintNode != null)
                                        {
                                            question.Hint = hintNode.InnerText;
                                        }

                                        XmlNode answersNode = qNode.SelectSingleNode("answers");
                                        if (answersNode != null)
                                        {
                                            XmlNodeList answerNodes = answersNode.SelectNodes("answer");
                                            if (answerNodes != null)
                                            {
                                                foreach (XmlNode aNode in answerNodes)
                                                {
                                                    Answer answer = new Answer();
                                                    answer.Text = aNode.InnerText;
                                                    if (aNode.Attributes["correct"] != null)
                                                    {
                                                        answer.IsCorrect = aNode.Attributes["correct"].Value == "true";
                                                    }
                                                    question.Answers.Add(answer);
                                                }
                                            }
                                        }

                                        level.Questions.Add(question);
                                    }
                                }

                                theme.Levels.Add(level);
                            }
                        }

                        themes.Add(theme);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка загрузки XML: {ex.Message}", "Ошибка",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return themes;
        }

        public bool ValidateXml()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}