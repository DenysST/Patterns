#region Header
// Copyright Koninklijke Philips N.V. 2023
#endregion

namespace Adapter;

public class MemoryCard {
    public void InsertIntoComputer() {
        Console.WriteLine("Successfully inserted");
    }
    
    public void CopyData() {
        Console.WriteLine("Successfully copied");
    }
}