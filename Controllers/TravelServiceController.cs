using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Travel_Service.Helper;
using Travel_Service.Models.Dtos;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Entity;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class TravelServiceController :ControllerBase
{
   
    private readonly ITravelPackageService _packageService;
    private readonly IBookingService _bookingService;
    private readonly IHotelsService _hotelService;
    private readonly IRoomsService _roomService;
    private readonly IFlightService _flightService;

    public TravelServiceController(
        ITravelPackageService packageService,
        IBookingService bookingService,
        IHotelsService hotelService,
        IRoomsService roomService,
        IFlightService flightService)
    {
        _packageService = packageService;
        _bookingService = bookingService;
        _hotelService = hotelService;
        _roomService = roomService;
        _flightService = flightService;
    }

    // --------------------- Travel Packages ---------------------

    // GET: api/Travel/packages
    [HttpGet("packages")]
    public async Task<IActionResult> GetAllPackages()
    {
        var packages = await _packageService.GetAllPackagesAsync();
        return Ok(packages);
    }

    // GET: api/Travel/packages/{id}
    [HttpGet("packages/{id}")]
    public async Task<IActionResult> GetPackageById(int id)
    {
        var package = await _packageService.GetPackageByIdAsync(id);
        if (package == null) return NotFound();
        return Ok(package);
    }

    // --------------------- Bookings ---------------------

    // POST: api/Travel/bookings
    [Authorize]
    [HttpPost("bookings")]
    public async Task<IActionResult> CreateBooking([FromBody] BookingRequestDto booking)
    {
        await _bookingService.AddBookingAsync(booking);
        return Ok(new { message = "Booking created successfully." });
    }

    // GET: api/Travel/bookings
    [Authorize]
    [HttpGet("bookings")]
    public async Task<IActionResult> GetAllBookings()
    {
        var bookings = await _bookingService.GetAllBookingsAsync();
        return Ok(bookings);
    }

    // GET: api/Travel/bookings/{id}
    [Authorize]
    [HttpGet("bookings/{id}")]
    public async Task<IActionResult> GetBookingById(int id)
    {
        var booking = await _bookingService.GetBookingByIdAsync(id);
        if (booking == null) return NotFound();
        return Ok(booking);
    }

    // --------------------- Hotels ---------------------

    // GET: api/Travel/hotels
    [HttpGet("hotels")]
    public async Task<IActionResult> GetAllHotels()
    {
        var hotels = await _hotelService.GetAllHotelsAsync();
        return Ok(hotels);
    }

    // GET: api/Travel/hotels/{id}
    [HttpGet("hotels/{id}")]
    public async Task<IActionResult> GetHotelById(int id)
    {
        var hotel = await _hotelService.GetHotelByIdAsync(id);
        if (hotel == null) return NotFound();
        return Ok(hotel);
    }

    // --------------------- Rooms ---------------------

    // GET: api/Travel/rooms
    [HttpGet("rooms")]
    public async Task<IActionResult> GetAllRooms()
    {
        var rooms = await _roomService.GetAllRoomsAsync();
        return Ok(rooms);
    }

    // GET: api/Travel/rooms/{id}
    [HttpGet("rooms/{id}")]
    public async Task<IActionResult> GetRoomById(int id)
    {
        var room = await _roomService.GetRoomByIdAsync(id);
        if (room == null) return NotFound();
        return Ok(room);
    }

    // --------------------- Flights ---------------------

    // GET: api/Travel/flights
    [HttpGet("flights")]
    public async Task<IActionResult> GetAllFlights()
    {
        var flights = await _flightService.GetAllFlightsAsync();
        return Ok(flights);
    }

    // GET: api/Travel/flights/{id}
    [HttpGet("flights/{id}")]
    public async Task<IActionResult> GetFlightById(int id)
    {
        var flight = await _flightService.GetFlightByIdAsync(id);
        if (flight == null) return NotFound();
        return Ok(flight);
    }
}