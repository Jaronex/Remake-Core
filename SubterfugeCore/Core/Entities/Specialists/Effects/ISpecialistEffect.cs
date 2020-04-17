﻿using SubterfugeCore.Core.Entities.Specialists.Effects.Enums;
using SubterfugeCore.Core.Interfaces;

namespace SubterfugeCore.Core.Entities.Specialists.Effects
{
    public interface ISpecialistEffect
    {
        /// <summary>
        /// Applies the effect's forward actions
        /// </summary>
        /// <param name="friendly">The friendly participant. Null if none.</param>
        /// <param name="enemy">The enemy participant. Null if none.</param>
        void ForwardEffect(ICombatable friendly, ICombatable enemy);
        
        /// <summary>
        /// Applies the backwards specialist effect
        /// </summary>
        /// <param name="friendly">The friendly participant. Null if none.</param>
        /// <param name="enemy">The enemy participant. Null if none.</param>
        void BackwardEffect(ICombatable friendly, ICombatable enemy);
    }
}
