using CardManager.Data;
using CardManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CardManager.Services;
public class CardService
{
    private readonly DataContext _context;
    public CardService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Card>> GetAllAsync()
    {
        try
        {
            var cards = await _context
                .Cards
                .AsNoTracking()
                .ToListAsync();
            if (cards == null)
                throw new Exception("Nenhuma carta foi encontrada");

            return cards;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Um erro ocorreu: " + ex.Message);
            throw;
        }
    }
    public async Task<Card> GetByIdAsync(int id)
    {
        try
        {
            var card = await _context.Cards.FirstOrDefaultAsync(card => card.Id == id);
            if (card == null)
                throw new Exception("Carta nao encontrada, verifique se o Id solicitado está correto");

            return card;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Um erro ocorreu: " + ex.Message);
            throw;
        }
    }
    public async Task CreateAsync(Card card)
    {
        try
        {
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Um erro ocorreu: " + ex.Message);
            throw;
        }
    }
    public async Task UpdateAsync(Card card)
    {
        try
        {
            _context.Cards.Update(card);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Um erro ocorreu: " + ex.Message);
            throw;
        }
    }
    public async Task DeleteAsync(int id)
    {
        try
        {
            var card = await _context.Cards.FirstOrDefaultAsync(card => card.Id == id);
            if (card == null)
            {
                throw new Exception("A carta solicitada não existe, verifique o Id");
            }
            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Um erro ocorreu: " + ex.Message);
            throw;
        }
    }
}