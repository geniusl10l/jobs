using System.ComponentModel.DataAnnotations;

namespace MJ_Rent_Login.Models
{
    public class Reserve
    {
        [Display(Name ="編號")]
        public int Id { get; set; }
        
        [Display(Name = "會議室編號")]
        public int RoomId { get; set; }
        
        [Display(Name = "使用者名稱")]
        public string? UserId { get; set; }
        
        //預約時間
        [Display(Name = "預約日期")]
        public DateTime ResDateTime { get; set; }

        //預約時間查長度 單位為分鐘，30,60,90,120,150,180,480可選
        [Display(Name = "預約時長")]
        public int ResTimeLength { get; set; }
    }
}
