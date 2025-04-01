namespace OMRApp.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public int QuestionNumber { get; set; }
        public int Number { get; set; }
        public string SelectedAnswer { get; set; }
        //public int CorrectAnswer { get; set; }

        public bool IsASelected { get; set; }
        public bool IsBSelected { get; set; }
        public bool IsCSelected { get; set; }
        public bool IsDSelected { get; set; }
    }
}
