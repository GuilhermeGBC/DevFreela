

namespace DevFreela.Application.InputModels
{
    public class NewProjectInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; set; }

    }
}
