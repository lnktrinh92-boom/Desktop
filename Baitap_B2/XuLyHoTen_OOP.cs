using System;
using System.Linq;
using System.Text;

namespace XuLyHoTen
{
    public class HoTen
    {
        public string FullName { get; set; }

        public HoTen(string name)
        {
            FullName = name.Trim();
        }

        public string HoLot()
        {
            string[] words = FullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length <= 1) return "";

            return string.Join(" ", words.Take(words.Length - 1));
        }

        public string Ten()
        {
            string[] words = FullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length > 0 ? words[words.Length - 1] : "";
        }

        public int DemTu()
        {
            return FullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public string HoaDauTu()
        {
            string[] words = FullName.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                sb.Append(char.ToUpper(word[0]) + word.Substring(1) + " ");
            }

            return sb.ToString().Trim();
        }
    }
}