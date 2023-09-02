const int MAX_DENOMINATIONS = 4;
const int MAX_TRANSACTIONS = 10;

int[] cashTill = new int[MAX_DENOMINATIONS];
int registerCheckTillTotal = 0;

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
int[,] registerDailyStartingCash = { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

int[] testData = { 6, 10, 17, 20, 31, 36, 40, 41 };
int testCounter = 0;

LoadTillEachMorning(registerDailyStartingCash, cashTill);
registerCheckTillTotal = CalculateRegisterStartingTotal(registerDailyStartingCash);

// Display the till status
LogTillStatus(cashTill);
Console.WriteLine(TillAmountSummary(cashTill));
Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

var valueGenerator = new Random();

int transactions = useTestData ? testData.Length : MAX_TRANSACTIONS;

for (int i = 0; i < transactions; i++)
{
    int itemCost = useTestData ? testData[testCounter++] : valueGenerator.Next(2, 20);

    // Calculate payments
    var payments = CalculatePayments(itemCost);

    // Display transaction details
    DisplayTransactionDetails(itemCost, payments);

    // Handle the transaction
    string transactionMessage = MakeChange(itemCost, cashTill, payments);
    if (transactionMessage == "transaction succeeded")
    {
        Console.WriteLine($"Transaction successfully completed.");
        registerCheckTillTotal += itemCost;
    }
    else
    {
        Console.WriteLine($"Transaction unsuccessful: {transactionMessage}");
    }

    Console.WriteLine(TillAmountSummary(cashTill));
    Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");
}

Console.WriteLine("Press the Enter key to exit");
Console.ReadLine();

// Moved the payment calculation logic to its own method
(int paymentTwenties, int paymentTens, int paymentFives, int paymentOnes) CalculatePayments(int itemCost)
{
    int paymentOnes = itemCost % 2;                 
    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; 
    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; 
    int paymentTwenties = (itemCost < 20) ? 1 : 2;  

    return (paymentTwenties, paymentTens, paymentFives, paymentOnes);
}

void DisplayTransactionDetails(int itemCost, (int, int, int, int) payments)
{
    Console.WriteLine($"Customer is making a ${itemCost} purchase");
    Console.WriteLine($"\t Using {payments.Item1} twenty dollar bills");
    Console.WriteLine($"\t Using {payments.Item2} ten dollar bills");
    Console.WriteLine($"\t Using {payments.Item3} five dollar bills");
    Console.WriteLine($"\t Using {payments.Item4} one dollar bills");
}

int CalculateRegisterStartingTotal(int[,] registerDailyStartingCash)
{
    int total = 0;
    for (int i = 0; i < MAX_DENOMINATIONS; i++)
    {
        total += registerDailyStartingCash[i, 0] * registerDailyStartingCash[i, 1];
    }
    return total;
}
