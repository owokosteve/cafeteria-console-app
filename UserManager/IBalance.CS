namespace cafeconnect;

interface IBalance
{
    decimal WalletBalance { get; }
    void RechargeWallet(decimal amount);
    bool DeductAmount(decimal amount);
    
}