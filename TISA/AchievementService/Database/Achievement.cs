﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AchievementService.Database
{
    public class Achievement
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public Guid AchievementId { get; internal set; }
    }
}