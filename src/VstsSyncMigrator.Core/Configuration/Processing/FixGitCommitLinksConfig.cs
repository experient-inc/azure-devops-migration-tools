﻿using System;
using System.Collections.Generic;

namespace VstsSyncMigrator.Engine.Configuration.Processing
{
    public class FixGitCommitLinksConfig : ITfsProcessingConfig
    {
        public Dictionary<string, string> TargetRepositoryMaps { get; set; }
        public string TargetRepository { get; set; }
        public string AreaPathRootFilter { get; set; }
        public bool Enabled { get; set; }
        
        public Type Processor
        {
            get { return typeof(FixGitCommitLinks); }
        }

        /// <inheritdoc />
        public bool IsProcessorCompatible(IReadOnlyList<ITfsProcessingConfig> otherProcessors)
        {
            return true;
        }
    }
}