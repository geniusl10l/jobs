using System.ComponentModel.DataAnnotations;
namespace MJ_Rent_Login.Models
{
    public class MeetRoom
    {
        [Display (Name="編號")]
        public int Id { get; set; }
        
        [Display(Name = "名稱")]
        public string? Name { get; set; }
        
        [Display(Name = "描述")]
        public string? Description { get; set; }
        
        [Display(Name = "類型")]
        public string? Type { get; set; }
        
        [Display(Name = "人數")]
        public int Capacity { get; set; }
        
        [Display(Name = "投影機")]
        public Boolean HaveProjector { get; set; }
        
        [Display(Name = "白板")]
        public Boolean HaveWhiteboard { get; set; }
        
        [Display(Name = "可以使用")]
        public Boolean IsActive { get; set; }
        public MeetRoom() { }
    }
}
