namespace _1._1_BinaryGap;
class Program
{
    public static int solution(int N){
        int maxgap = 0;
        int curgap = 0;

        String binary = Convert.ToString(N, 2);
        Console.WriteLine(binary);
        if(N > 0 && N <= 2147483647){
            if(binary.Length > 2){
                for(int i = 1; i < binary.Length; i++){
                    if(binary[i-1] == '1' && binary[i] == '0'){
                        curgap = 1;
                    }
                    else if (binary[i-1] == '0' && binary[i] == '0' && curgap > 0){
                        curgap++;
                    }
                    else if (binary[i-1] == '0' && binary[i] == '1'){
                        if(curgap > 0){
                            if(curgap > maxgap){
                                maxgap = curgap;
                            }
                            curgap = 0;
                        }
                    }
                }
            }
        }
        return maxgap;
    }

    static void Main(string[] args)
    {
        int N = 1073741824;

        int result = solution(N);

        Console.WriteLine(result);

    }
}
