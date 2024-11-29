using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private Text UserName;
    [SerializeField] private Text BalanceMoney;
    [SerializeField] private Text CashMoney;

    private void Start()
    {
        Refresh();
    }

    void Refresh()
    {
        UserName.text = GameManager.instance.User.Name;
        BalanceMoney.text = GameManager.instance.User.Balance.ToString();
        CashMoney.text = GameManager.instance.User.Cash.ToString();
    }

    public void Deposit(int money)
    {
        bool isComplete = GameManager.instance.User.Deposit(money);

        if (isComplete)
        {
            Debug.Log("�Ա� ����!");
            Refresh();
        }
        else
            Debug.Log("�Ա� ����!!");
    }

    public void CustomDeposit(InputField inputfield)
    {
        Deposit(int.Parse(inputfield.text));
    }

    public void Withdraw(int money)
    {
        bool isComplete = GameManager.instance.User.Withdraw(money);

        if (isComplete)
        {
            Debug.Log("��� ����!");
            Refresh();
        }
        else
            Debug.Log("��� ����!!");
    }

    public void CustomWithdraw(InputField inputfield)
    {
        Withdraw(int.Parse(inputfield.text));
    }
}
