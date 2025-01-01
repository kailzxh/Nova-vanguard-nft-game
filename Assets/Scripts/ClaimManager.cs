using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using System.Threading.Tasks;
public class ClaimManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public async Task ClaimNFT(){
        Contract contract = SDKManager.instance.SDK.GetContract("0x22102a98EF206C7A85dc1297476D27464256fA06");
        await contract.ERC721.Claim(1);
    }
    public async void Claim(){
        await ClaimNFT();
    }
}
