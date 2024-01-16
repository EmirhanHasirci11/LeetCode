namespace InsertDeleteGetRandomO_1_
{
    public class RandomizedSet
    {      
        HashSet<int> set = new();
        Random rnd = new();

        public bool Insert(int n) => set.Add(n);

        public bool Remove(int n) => set.Remove(n);

        public int GetRandom() => set.ElementAt(rnd.Next(set.Count));
    }

}