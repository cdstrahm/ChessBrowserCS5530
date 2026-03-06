using ChessBrowser.Components.Models;
using ChessBrowser.Components.Parser;

namespace ChessBrowser.Tests;
using Xunit;

public class ParserTests
{
    [Fact]
    public void ParsePgnFileCheckCountIs975()
    {
        PgnParser.ParseFile("TestData/kb1.pgn", 
            out Dictionary<string, ChessPlayer>? players, out Dictionary<(string Name, string Site, string Date), ChessEvent>? events, 
            out List<ChessGame>? games);
        Assert.Equal(975, games.Count);
    }
    
    [Fact]
    public void ParsePgnFileCheckCountIs1005()
    {
        PgnParser.ParseFile("TestData/kb2.pgn", 
            out Dictionary<string, ChessPlayer>? players, out Dictionary<(string Name, string Site, string Date), ChessEvent>? events, 
            out List<ChessGame>? games);
        Assert.Equal(1005, games.Count);
    }
    
    [Fact]
    public void ParsePgnFileCheckCountIs1019()
    {
        PgnParser.ParseFile("TestData/kb3.pgn", 
            out Dictionary<string, ChessPlayer>? players, out Dictionary<(string Name, string Site, string Date), ChessEvent>? events, 
            out List<ChessGame>? games);
        Assert.Equal(1019, games.Count);
    }
    
    [Fact]
    public void ParsePgnFileCheckEventNameKb1()
    {
        PgnParser.ParseFile("TestData/kb1.pgn", 
            out Dictionary<string, ChessPlayer>? players, out Dictionary<(string Name, string Site, string Date), ChessEvent>? events, 
            out List<ChessGame>? games);
        bool val = events.TryGetValue(("CZE Ch Blitz 2018", "Prague CZE", "2018-12-22"), out ChessEvent? value);
        Assert.True(val);
    }
    
    [Fact]
    public void ParsePgnFileCheckEventNameKb2()
    {
        PgnParser.ParseFile("TestData/kb2.pgn", 
            out Dictionary<string, ChessPlayer>? players, out Dictionary<(string Name, string Site, string Date), ChessEvent>? events, 
            out List<ChessGame>? games);
        bool val = events.TryGetValue(("37. Barbera del Valles Open 2014", "Barbera del Valles ESP", "2014-07-04"), out ChessEvent? value);
        Assert.True(val);
    }
    
    [Fact]
    public void ParsePgnFileCheckEventNameKb3()
    {
        PgnParser.ParseFile("TestData/kb3.pgn", 
            out Dictionary<string, ChessPlayer>? players, out Dictionary<(string Name, string Site, string Date), ChessEvent>? events, 
            out List<ChessGame>? games);
        bool val = events.TryGetValue(("Dato Arthur Tan Malaysian Op", "Kuala Lumpur MAS", "2007-08-20"), out ChessEvent? value);
        Assert.True(val);
    }
}