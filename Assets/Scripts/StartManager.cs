using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using Thirdweb;
using Org.BouncyCastle.Math;

public class StartManager : MonoBehaviour
{
    public GameObject connected;
    public GameObject disconnted;
    public GameObject enterbtn;
    public TMPro.TextMeshProUGUI addressTxt;
    public TMPro.TextMeshProUGUI ownsNft;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public async void ConnectWallet(){
          
   string address = await SDKManager.instance.SDK.wallet.Connect(new WalletConnection(provider: WalletProvider.Metamask , chainId :11155111));
   addressTxt.text=address;
   
   connected.SetActive(false);
   disconnted.SetActive(false); 
   await CheckBalance();
    }

    public async Task CheckBalance(){
        Contract contract = SDKManager.instance.SDK.GetContract("0x22102a98EF206C7A85dc1297476D27464256fA06");
        string balance = await contract.ERC721.Balance();
        float balanceText = float.Parse(balance);
        if(balanceText==0){
            ownsNft.text = "you cant access the game ";
            return;
        }
        ownsNft.text="welcome to the game";
        enterbtn.SetActive(true);
    }
    public void EnterGame(){
       
        SceneManager.LoadScene("MainLevel");
    }
}
