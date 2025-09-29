namespace Travel_Service.Models.Dtos.Response;

public class BookedPackageResponseDetails
{
    public string Message { get; set; }
    public BookingResponseDto Booking { get; set; }
    public bool IsSuccess { get; set; }
    


}

/*
    public string Message { get; set; }
   public DiaryModelDto DiaryModel { get; set; }
   public bool IsSuccess { get; set; }
   public string Token { get; set; }
   
*/