﻿using System;
using Atanasio1.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Atanasio1.API.Data;
using System.Net.Sockets;

namespace Atanasio1.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Ticket.Any())
            {

                for (int i = 0; i < 50000; i++)
                {
                    Guid guid = Guid.NewGuid();

                    _context.Ticket.Add(new Ticket { TicketId = guid.ToString(), UseDate = null, isUsed = false, Entrance = null });
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}