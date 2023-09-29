using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetaislViewModel
    {
        public ProjectDetaislViewModel(int id, string title, string description, decimal totalCost, DateTime? startedAt, DateTime? finishedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? TotalCost { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
    }
}
