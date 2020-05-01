﻿using System.Threading.Tasks;

namespace MijnSauna.Frontend.Phone.Services.Interfaces
{
    public interface IStatusBarService
    {
        Task<bool> SetStatusBarColorFromArgb(int alpha, int red, int green, int blue);
    }
}