public class Convert {

    public static int BoolToInt(bool boolean)
    {
        if (boolean) return 1;
        return 0;
    }

    public static bool IntToBool(int integer)
    {
        if (integer == 1) return true;
        if (integer == 0) return false;
        throw new System.Exception();
    }
}
