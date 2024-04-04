namespace CADeadLock
{
    class TransferManager
    {
        private Wallet? _from;
        private Wallet? _to;
        private int _amountToTransfer;

        public TransferManager(Wallet? from, Wallet? to, int amountToTransfer)
        {
            this._from = from;
            this._to = to;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} Trying to Lock ... {_from}");
            lock (_from!)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Lock Acquired ... {_from}");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} Trying to Lock ... {_to}");

                //lock (_to!)
                //{
                //    Console.WriteLine($"{Thread.CurrentThread.Name} Lock Acquired ... {_to}");
                //    _from.Debit(_amountToTransfer);
                //    _to.Credit(_amountToTransfer);
                //}

                if (Monitor.TryEnter(_to!, 1000))
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} Lock Acquired ... {_to}");
                    try
                    {
                        _from.Debit(_amountToTransfer);
                        _to!.Credit(_amountToTransfer);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally 
                    {
                        Monitor.Exit(_to!);
                    }
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} " +
                        $"Unable to Lock Acquired on ... {_to}");
                }
            }
        }
    }
}
