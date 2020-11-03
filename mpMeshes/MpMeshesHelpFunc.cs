namespace mpMeshes
{
    using System.Collections.Generic;
    using ModPlusAPI;

    public class MpMeshesHelpFunc
    {
        /// <summary>
        /// Заполнение окна вывода сообщений
        /// </summary>
        /// <param name="number">Номер сообщения</param>
        /// <param name="str">Дополнительное текстовое значение</param>
        public string Message(int number, string str)
        {
            var messages = new List<string>
            {
                string.Empty,
                $"{Language.GetItem("h60")} {str} {Language.GetItem("mm")}",
                $"{Language.GetItem("h61")} {str} {Language.GetItem("mm")}",
                $"{Language.GetItem("h62")} {str} {Language.GetItem("mm")}",
                $"{Language.GetItem("h63")} {str} {Language.GetItem("mm")}"
            };
            return messages[number];
        }
    }
}