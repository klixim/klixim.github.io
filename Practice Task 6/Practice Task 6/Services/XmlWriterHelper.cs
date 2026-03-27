using Practice_Task_6.Models;
using System;
using System.Windows.Forms;
using System.Xml;

namespace Practice_Task_6.Services
{
    public class XmlWriterHelper
    {
        private string filePath;

        public XmlWriterHelper(string path)
        {
            filePath = path;
        }

        public void AddQuestionToTheme(string themeName, int levelDifficulty, InventionQuestion question)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                // Найти или создать тему
                XmlNode themeNode = doc.SelectSingleNode($"/inventions/theme[@name='{themeName}']");
                if (themeNode == null)
                {
                    themeNode = doc.CreateElement("theme");
                    XmlAttribute nameAttr = doc.CreateAttribute("name");
                    nameAttr.Value = themeName;
                    themeNode.Attributes.Append(nameAttr);
                    doc.DocumentElement.AppendChild(themeNode);
                }

                // Найти или создать уровень
                XmlNode levelNode = themeNode.SelectSingleNode($"level[@difficulty='{levelDifficulty}']");
                if (levelNode == null)
                {
                    levelNode = doc.CreateElement("level");
                    XmlAttribute diffAttr = doc.CreateAttribute("difficulty");
                    diffAttr.Value = levelDifficulty.ToString();
                    levelNode.Attributes.Append(diffAttr);
                    themeNode.AppendChild(levelNode);
                }

                // Создать вопрос
                XmlElement qNode = doc.CreateElement("question");

                XmlElement inventionNode = doc.CreateElement("invention");
                inventionNode.InnerText = question.InventionName;
                qNode.AppendChild(inventionNode);

                XmlElement imageNode = doc.CreateElement("image");
                imageNode.InnerText = question.ImagePath;
                qNode.AppendChild(imageNode);

                XmlElement answersNode = doc.CreateElement("answers");
                foreach (var ans in question.Answers)
                {
                    XmlElement aNode = doc.CreateElement("answer");
                    aNode.SetAttribute("correct", ans.IsCorrect ? "true" : "false");
                    aNode.InnerText = ans.Text;
                    answersNode.AppendChild(aNode);
                }
                qNode.AppendChild(answersNode);

                XmlElement hintNode = doc.CreateElement("hint");
                hintNode.InnerText = question.Hint;
                qNode.AppendChild(hintNode);

                levelNode.AppendChild(qNode);
                doc.Save(filePath);

                MessageBox.Show("Вопрос успешно добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении вопроса: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateQuestion(string themeName, int levelDifficulty, int questionIndex, InventionQuestion question)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNode themeNode = doc.SelectSingleNode($"/inventions/theme[@name='{themeName}']");
                if (themeNode == null) return;

                XmlNode levelNode = themeNode.SelectSingleNode($"level[@difficulty='{levelDifficulty}']");
                if (levelNode == null) return;

                XmlNodeList questionNodes = levelNode.SelectNodes("question");
                if (questionNodes != null && questionIndex < questionNodes.Count)
                {
                    XmlNode qNode = questionNodes[questionIndex];

                    qNode.SelectSingleNode("invention").InnerText = question.InventionName;
                    qNode.SelectSingleNode("image").InnerText = question.ImagePath;
                    qNode.SelectSingleNode("hint").InnerText = question.Hint;

                    XmlNode answersNode = qNode.SelectSingleNode("answers");
                    answersNode.RemoveAll();

                    foreach (var ans in question.Answers)
                    {
                        XmlElement aNode = doc.CreateElement("answer");
                        aNode.SetAttribute("correct", ans.IsCorrect ? "true" : "false");
                        aNode.InnerText = ans.Text;
                        answersNode.AppendChild(aNode);
                    }

                    doc.Save(filePath);
                    MessageBox.Show("Вопрос успешно обновлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении вопроса: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteQuestion(string themeName, int levelDifficulty, int questionIndex)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNode themeNode = doc.SelectSingleNode($"/inventions/theme[@name='{themeName}']");
                if (themeNode == null) return;

                XmlNode levelNode = themeNode.SelectSingleNode($"level[@difficulty='{levelDifficulty}']");
                if (levelNode == null) return;

                XmlNodeList questionNodes = levelNode.SelectNodes("question");
                if (questionNodes != null && questionIndex < questionNodes.Count)
                {
                    levelNode.RemoveChild(questionNodes[questionIndex]);
                    doc.Save(filePath);
                    MessageBox.Show("Вопрос успешно удален!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении вопроса: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}