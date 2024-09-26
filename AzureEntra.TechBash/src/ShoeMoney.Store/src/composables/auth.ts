import { PublicClientApplication, type AccountInfo} from "@azure/msal-browser";
import { reactive } from "vue";

const config = {
  auth: {
    clientId: import.meta.env.VITE_CLIENTID,
    authority: `https://login.microsoftonline.com/${import.meta.env.VITE_TENANTID}`
  }
}

const data = reactive({
  account: null as AccountInfo | null,
  token: "",
  msalInstance: new PublicClientApplication(config),
  logout,
  login,
  isValid: function () { return this.account !== null }
});

async function login() {
  try {
    await data.msalInstance.initialize();

    await data.msalInstance.loginPopup();
    //await data.msalInstance.loginRedirect();
    const accounts = data.msalInstance.getAllAccounts();
    data.account = accounts[0];

    const response = await data.msalInstance.acquireTokenSilent({
      scopes: [`api://${import.meta.env.VITE_CLIENTID}/theapi`],
      account: data.account
    })

    data.token = response.accessToken;

    return true;
  } catch {
    // TODO 
  }

  return false;
}

async function logout() {
  await data.msalInstance.logoutPopup();
  data.account = null;
  data.token = "";
}

export function useAuth() {
  return data;
}