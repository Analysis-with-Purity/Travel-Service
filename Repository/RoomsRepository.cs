using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class RoomsRepository: IRoomsRepository
{
    private readonly ApplicationDbContext _context;

    public RoomsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Room>> GetAllRoomsAsync()
    {
        return await _context.Rooms.Include(r => r.Hotel).ToListAsync();
    }

    public async Task<Room> GetRoomByIdAsync(int roomId)
    {
        return await _context.Rooms.Include(r => r.Hotel)
            .FirstOrDefaultAsync(r => r.RoomId == roomId);
    }

    public async Task AddRoomAsync(Room room)
    {
        await _context.Rooms.AddAsync(room);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRoomAsync(Room room)
    {
        _context.Rooms.Update(room);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRoomAsync(int roomId)
    {
        var room = await _context.Rooms.FindAsync(roomId);
        if (room != null)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }
    }
}