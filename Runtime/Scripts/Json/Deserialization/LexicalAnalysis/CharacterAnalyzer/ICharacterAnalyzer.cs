﻿namespace OpenAi.Json
{
    /// <summary>
    /// Analyzes a character
    /// </summary>
    public interface ICharacterAnalyzer
    {
        ECharacterAnalyzerResponse Analyze(char c, out ICharacterAnalyzer engage);
    }
}
