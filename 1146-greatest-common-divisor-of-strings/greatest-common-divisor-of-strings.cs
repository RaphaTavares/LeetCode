public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (!(str1 + str2).Equals(str2 + str1)) {
            return "";
        }

        int gcdLength = GCD(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);
    }

    private int GCD(int a, int b) {
        if (b == 0) return a;
        return GCD(b, a % b);
    }
}
