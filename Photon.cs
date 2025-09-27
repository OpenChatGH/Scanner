using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000555 RID: 1365
public class PNNODLLHJMG : IPhotonPeerListener
{
	// Token: 0x0600DB04 RID: 56068 RVA: 0x00549A1C File Offset: 0x00547C1C
	public bool MCCGOPPKMON(Hashtable AFBBHKHBHCK, Hashtable GNGODJIJJKF = null, LHFAIKEHMFD MNPOONDKPOK = null)
	{
		if (this.IHOAIEDNILP == null)
		{
			if (this.MBBOGGKAFJI.DebugOut >= DebugLevel.ERROR)
			{
				this.DebugReturn(DebugLevel.ERROR, "OpSetPropertiesOfRoom() failed because this client is not in a room currently. State: " + this.AGAADNLBHCE);
			}
			return false;
		}
		if (GNGODJIJJKF == null || GNGODJIJJKF.Count == 0)
		{
			this.IHOAIEDNILP.DEDOKBOAPCG(AFBBHKHBHCK);
		}
		return this.MBBOGGKAFJI.MCCGOPPKMON(AFBBHKHBHCK, GNGODJIJJKF, MNPOONDKPOK);
	}

	// Token: 0x0600DB05 RID: 56069 RVA: 0x000545B5 File Offset: 0x000527B5
	public void MDJEBKPHKAP(string MKANAGHCFCD)
	{
		if (this.NCCDOCBKBBE == null)
		{
			this.NCCDOCBKBBE = new AKBLJMMBAKI();
		}
		this.NCCDOCBKBBE.NMKLPFBGCBM(MKANAGHCFCD);
	}

	// Token: 0x0600DB06 RID: 56070 RVA: 0x000545D9 File Offset: 0x000527D9
	public void AOMGNFJPNDN(bool MKANAGHCFCD)
	{
		this.<LJOLEPDFHHG>k__BackingField = MKANAGHCFCD;
	}

	// Token: 0x0600DB07 RID: 56071 RVA: 0x000545E2 File Offset: 0x000527E2
	public string OMAPKPPLMLE()
	{
		return this.<INNCHNLNBEN>k__BackingField;
	}

	// Token: 0x0600DB08 RID: 56072 RVA: 0x00549A90 File Offset: 0x00547C90
	public bool FFFAGFBKCEH(string OHMDKONJDLE)
	{
		this.NGJJCBLCHHL = true;
		if (this.AGAADNLBHCE == (MOCMDLAOOBB)39)
		{
			this.DCIECCLCEIB = OHMDKONJDLE;
			return this.OHCBAMCMDHI();
		}
		this.MBBOGGKAFJI.Disconnect();
		this.DCIECCLCEIB = OHMDKONJDLE;
		if (this.JEBOPFMOPHC == (HPGOLAFBMBL)4)
		{
			this.LNFKFFLKPPH = this.EFLMACPOPJD().TransportProtocol;
			this.MBBOGGKAFJI.TransportProtocol = (ConnectionProtocol)6;
		}
		if (!this.EFLMACPOPJD().Connect(this.FOMNDMLBGJJ, "WarnUserRPC", null))
		{
			return true;
		}
		this.AGAADNLBHCE = (MOCMDLAOOBB)91;
		return false;
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x00054702 File Offset: 0x00052902
	// (set) Token: 0x0600DB09 RID: 56073 RVA: 0x000545EA File Offset: 0x000527EA
	public NPBDDBPFMKB IHOAIEDNILP { get; private set; }

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x0600DB0A RID: 56074 RVA: 0x000545F3 File Offset: 0x000527F3
	// (set) Token: 0x0600DB68 RID: 56168 RVA: 0x0054C214 File Offset: 0x0054A414
	public MOCMDLAOOBB AGAADNLBHCE
	{
		get
		{
			return this.KELAMIMFMPM;
		}
		set
		{
			if (this.KELAMIMFMPM == value)
			{
				return;
			}
			MOCMDLAOOBB kelamimfmpm = this.KELAMIMFMPM;
			this.KELAMIMFMPM = value;
			if (this.IOJFLLACKJO != null)
			{
				this.IOJFLLACKJO(kelamimfmpm, this.KELAMIMFMPM);
			}
		}
	}

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x0600DB0B RID: 56075 RVA: 0x000545FB File Offset: 0x000527FB
	// (set) Token: 0x0600DB38 RID: 56120 RVA: 0x00054758 File Offset: 0x00052958
	public string PDEKDKHMPMK { get; protected internal set; }

	// Token: 0x0600DB0C RID: 56076 RVA: 0x00549B24 File Offset: 0x00547D24
	public bool BPEIMOMFHND(EHIFDKPENKA LANBPHNDNJO)
	{
		bool flag = this.KGKLCBPOMEO == PJPJONLOJHN.GameServer;
		LANBPHNDNJO.MBLIFOKBJLH = flag;
		if (!flag)
		{
			this.DABODHJPFGP = LANBPHNDNJO;
		}
		bool flag2 = this.MBBOGGKAFJI.BPEIMOMFHND(LANBPHNDNJO);
		if (flag2)
		{
			this.GNGJAKNCNDA = ((!LANBPHNDNJO.JIELBJCMIIH) ? IBGKHAGLJAA.JoinRoom : IBGKHAGLJAA.JoinOrCreateRoom);
			this.AGAADNLBHCE = MOCMDLAOOBB.Joining;
		}
		return flag2;
	}

	// Token: 0x0600DB0D RID: 56077 RVA: 0x00054603 File Offset: 0x00052803
	public bool IOCOAJKMGBE()
	{
		return this.MBBOGGKAFJI.IOCOAJKMGBE();
	}

	// Token: 0x0600DB0E RID: 56078 RVA: 0x00054610 File Offset: 0x00052810
	public void KJIIEEEKHCE()
	{
		if (this.MBBOGGKAFJI != null)
		{
			this.MBBOGGKAFJI.Service();
		}
	}

	// Token: 0x0600DB0F RID: 56079 RVA: 0x00054628 File Offset: 0x00052828
	public PNNODLLHJMG(string ENHHLNHFEAA, string JEEMJBLLOPE, string OBDKBNLKNJP, ConnectionProtocol EJICODOLPEL = ConnectionProtocol.Udp) : this(EJICODOLPEL)
	{
		this.DIPGCCEJDLC = ENHHLNHFEAA;
		this.OLONLCFBHAN = JEEMJBLLOPE;
		this.OAEIKHMLDNC = OBDKBNLKNJP;
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x0600DB61 RID: 56161 RVA: 0x00054877 File Offset: 0x00052A77
	// (set) Token: 0x0600DB10 RID: 56080 RVA: 0x00054647 File Offset: 0x00052847
	public AMFNLONEKCH IMLJOLPDBFJ { get; set; }

	// Token: 0x0600DB11 RID: 56081 RVA: 0x00549B84 File Offset: 0x00547D84
	public bool HAMCGFOBJIN(Hashtable CMAGHKKIJHO, Hashtable GNGODJIJJKF = null, LHFAIKEHMFD MNPOONDKPOK = null)
	{
		Hashtable hashtable = new Hashtable();
		hashtable.MOAFPHGNMHL(CMAGHKKIJHO);
		return this.MCCGOPPKMON(hashtable, GNGODJIJJKF, MNPOONDKPOK);
	}

	// Token: 0x0600DB12 RID: 56082 RVA: 0x00549BA8 File Offset: 0x00547DA8
	public void OFHONNIDABE(Action<OperationResponse> MKANAGHCFCD)
	{
		Action<OperationResponse> action = this.NBHLMGOHHHA;
		Action<OperationResponse> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<OperationResponse>>(ref this.NBHLMGOHHHA, (Action<OperationResponse>)Delegate.Remove(action2, MKANAGHCFCD), action);
		}
		while (action != action2);
	}

	// Token: 0x0600DB13 RID: 56083 RVA: 0x00549BE0 File Offset: 0x00547DE0
	private void OILBAMJPFHF(Hashtable AFBBHKHBHCK, Hashtable DFPBLAHKKKL, int MJJFEDJFMDG, int DJHMMNODJHD)
	{
		if (this.IHOAIEDNILP != null && AFBBHKHBHCK != null)
		{
			this.IHOAIEDNILP.DEDOKBOAPCG(AFBBHKHBHCK);
			this.LNDNNBEMFOG.OnRoomPropertiesUpdate(AFBBHKHBHCK);
		}
		if (DFPBLAHKKKL != null && DFPBLAHKKKL.Count > 0)
		{
			if (MJJFEDJFMDG > 0)
			{
				OKMMOLCOKBF okmmolcokbf = this.IHOAIEDNILP.AJKBBPEFLGD(MJJFEDJFMDG);
				if (okmmolcokbf != null && (DJHMMNODJHD == 0 || DJHMMNODJHD == okmmolcokbf.AFJHLMCKOMM))
				{
					Hashtable hashtable = this.FAFBEBJBGOJ(DFPBLAHKKKL, MJJFEDJFMDG);
					okmmolcokbf.DEDOKBOAPCG(hashtable);
					this.LNDNNBEMFOG.OnPlayerPropertiesUpdate(okmmolcokbf, hashtable);
				}
				else
				{
					UnityEngine.Debug.LogErrorFormat("Received suspicious property change from {0} for {1}", new object[]
					{
						DJHMMNODJHD,
						(okmmolcokbf != null) ? okmmolcokbf.AFJHLMCKOMM.ToString() : "null"
					});
				}
			}
			else
			{
				foreach (object obj in DFPBLAHKKKL.Keys)
				{
					int num = (int)obj;
					Hashtable hashtable2 = (Hashtable)DFPBLAHKKKL[obj];
					string jcikldokoom = (string)hashtable2[byte.MaxValue];
					OKMMOLCOKBF okmmolcokbf2 = this.IHOAIEDNILP.AJKBBPEFLGD(num);
					if (okmmolcokbf2 == null && DJHMMNODJHD == 0)
					{
						okmmolcokbf2 = this.JIHCEKPCPKO(jcikldokoom, num, false, hashtable2);
						this.IHOAIEDNILP.FACOGGCAGPA(okmmolcokbf2);
					}
					if (okmmolcokbf2 == null || (okmmolcokbf2.AFJHLMCKOMM != DJHMMNODJHD && DJHMMNODJHD != 0))
					{
						UnityEngine.Debug.LogErrorFormat("Received suspicious property change from {0} for {1}", new object[]
						{
							DJHMMNODJHD,
							(okmmolcokbf2 != null) ? okmmolcokbf2.AFJHLMCKOMM.ToString() : "null"
						});
					}
					else
					{
						okmmolcokbf2.DEDOKBOAPCG(hashtable2);
						this.LNDNNBEMFOG.OnPlayerPropertiesUpdate(okmmolcokbf2, hashtable2);
					}
				}
			}
		}
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x0600DB14 RID: 56084 RVA: 0x00054650 File Offset: 0x00052850
	// (set) Token: 0x0600DB22 RID: 56098 RVA: 0x0005467A File Offset: 0x0005287A
	public AKBLJMMBAKI NCCDOCBKBBE { get; set; }

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x0600DB3D RID: 56125 RVA: 0x0005476A File Offset: 0x0005296A
	// (set) Token: 0x0600DB15 RID: 56085 RVA: 0x00054658 File Offset: 0x00052858
	public FNLJIBNMNGP MBBOGGKAFJI { get; private set; }

	// Token: 0x0600DB16 RID: 56086 RVA: 0x00549DF8 File Offset: 0x00547FF8
	public virtual void EFDHGGPONGN(EventData DJLBKBBJMMJ)
	{
		int sender = DJLBKBBJMMJ.Sender;
		OKMMOLCOKBF okmmolcokbf = (this.IHOAIEDNILP == null) ? null : this.IHOAIEDNILP.JLCBLMOBCHK(sender);
		byte code = DJLBKBBJMMJ.Code;
		switch (code)
		{
		case 168:
			if (this.NCCDOCBKBBE == null)
			{
				this.NCCDOCBKBBE = new AKBLJMMBAKI();
			}
			this.NCCDOCBKBBE.DLKLNOLOJNF(DJLBKBBJMMJ[(byte)-83] as string);
			this.AFIIBBJGFLH = this.NCCDOCBKBBE.COGIHHFHNPJ();
			break;
		case 169:
		{
			string[] array = DJLBKBBJMMJ[28] as string[];
			byte[] array2 = DJLBKBBJMMJ[67] as byte[];
			int[] array3 = DJLBKBBJMMJ[10] as int[];
			int[] array4 = DJLBKBBJMMJ[(byte)-73] as int[];
			this.NMLJNJJPJDG.Clear();
			for (int i = 1; i < array.Length; i++)
			{
				JIANHCEINKO jianhceinko = new JIANHCEINKO();
				jianhceinko.JMFLIOIAJHA = array[i];
				jianhceinko.LMDGJAKKCEO = (KOJGGEBNMFJ)array2[i];
				jianhceinko.LGFNJMCPHPP = array3[i];
				jianhceinko.BOMKCPDGHBJ = array4[i];
				this.NMLJNJJPJDG.Add(jianhceinko);
			}
			this.DHHHLDGPALJ.AHAEPNHGALK(this.NMLJNJJPJDG);
			break;
		}
		default:
			switch (code)
			{
			case 108:
			{
				int num = 0;
				if (DJLBKBBJMMJ.Parameters.ContainsKey(30))
				{
					num = (int)DJLBKBBJMMJ[(byte)-170];
				}
				Hashtable afbbhkhbhck = null;
				Hashtable dfpblahkkkl = null;
				if (num == 0)
				{
					afbbhkhbhck = (Hashtable)DJLBKBBJMMJ[(byte)-145];
				}
				else
				{
					dfpblahkkkl = (Hashtable)DJLBKBBJMMJ[129];
				}
				this.OILBAMJPFHF(afbbhkhbhck, dfpblahkkkl, num, sender);
				break;
			}
			case 109:
			{
				bool flag = true;
				if (DJLBKBBJMMJ.Parameters.ContainsKey((byte)-106))
				{
					flag = (bool)DJLBKBBJMMJ.Parameters[129];
				}
				if (flag)
				{
					okmmolcokbf.OMDENLCAPGI = true;
				}
				else
				{
					this.IHOAIEDNILP.IMELBBNEAOO(sender);
				}
				if (DJLBKBBJMMJ.Parameters.ContainsKey((byte)-67))
				{
					int num2 = (int)DJLBKBBJMMJ[168];
					if (num2 != 0)
					{
						this.IHOAIEDNILP.FAMAJOILPPJ = num2;
						this.LNDNNBEMFOG.OnMasterClientSwitched(this.IHOAIEDNILP.AJKBBPEFLGD(num2));
					}
				}
				this.LNDNNBEMFOG.FLNCJIMMLMI(okmmolcokbf);
				break;
			}
			case 110:
			{
				Hashtable hashtable = (Hashtable)DJLBKBBJMMJ[(byte)-8];
				if (okmmolcokbf == null)
				{
					okmmolcokbf = this.JIHCEKPCPKO(string.Empty, sender, true, hashtable);
					this.IHOAIEDNILP.JFAMPJCIBDD(okmmolcokbf);
				}
				else
				{
					okmmolcokbf.INMEKHIKOLA(hashtable);
					okmmolcokbf.OEIMJIADJEN(false);
				}
				if (sender == this.HDGIOHLBJKI.AFJHLMCKOMM)
				{
					int[] oolilngphof = (int[])DJLBKBBJMMJ[4];
					this.FEOIDINAMCO(oolilngphof);
					if (this.GNGJAKNCNDA == IBGKHAGLJAA.JoinRoom && this.HDGIOHLBJKI.AFJHLMCKOMM == 1)
					{
						this.DGKMJDICLFG.FKLKHEEOHLJ();
					}
					this.DGKMJDICLFG.KIEJLJBGDCB();
				}
				else
				{
					this.LNDNNBEMFOG.PLEBIPKCIBF(okmmolcokbf);
				}
				break;
			}
			}
			break;
		case 171:
			this.PFBPJIFMAFP = (int)DJLBKBBJMMJ[188];
			this.HPHLFHOLCGP = (int)DJLBKBBJMMJ[74];
			this.LNLDNFGGEAF = (int)DJLBKBBJMMJ[166];
			break;
		case 174:
		case 175:
		{
			List<LDMGFJEMGAF> list = new List<LDMGFJEMGAF>();
			Hashtable hashtable2 = (Hashtable)DJLBKBBJMMJ[(byte)-19];
			foreach (object obj in hashtable2.Keys)
			{
				string text = (string)obj;
				list.Add(new LDMGFJEMGAF(text, (Hashtable)hashtable2[text]));
			}
			this.DHHHLDGPALJ.NHJJMLOEMIM(list);
			break;
		}
		}
		if (this.AHEJPDFCJBO != null)
		{
			this.AHEJPDFCJBO(DJLBKBBJMMJ);
		}
	}

	// Token: 0x0600DB17 RID: 56087 RVA: 0x0054A268 File Offset: 0x00548468
	public bool FGDIKHANMPE(int OCKLBOGBDPH, Hashtable CMAGHKKIJHO, Hashtable GNGODJIJJKF = null, LHFAIKEHMFD MNPOONDKPOK = null)
	{
		if (this.IHOAIEDNILP != null)
		{
			Hashtable hashtable = new Hashtable();
			hashtable.MOAFPHGNMHL(CMAGHKKIJHO);
			return this.DCOHPOMDGNM(OCKLBOGBDPH, hashtable, GNGODJIJJKF, MNPOONDKPOK);
		}
		if (GNGODJIJJKF == null && MNPOONDKPOK == null && this.HDGIOHLBJKI != null && this.HDGIOHLBJKI.AFJHLMCKOMM == OCKLBOGBDPH)
		{
			this.HDGIOHLBJKI.EOMDCBPEDFD(CMAGHKKIJHO, null, null);
			return true;
		}
		if (this.MBBOGGKAFJI.DebugOut >= DebugLevel.ERROR)
		{
			this.DebugReturn(DebugLevel.ERROR, "OpSetCustomPropertiesOfActor() failed. To use expectedProperties or webForward, you have to be in a room. State: " + this.AGAADNLBHCE);
		}
		return false;
	}

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x0600DB18 RID: 56088 RVA: 0x00054661 File Offset: 0x00052861
	// (set) Token: 0x0600DB51 RID: 56145 RVA: 0x000547FD File Offset: 0x000529FD
	public bool OGLEHMOODPG { get; private set; }

	// Token: 0x0600DB19 RID: 56089 RVA: 0x0054A300 File Offset: 0x00548500
	public void CNJPDIFLNMN(object KIOPGOGHBMD)
	{
		HGJJGKJAEMB hgjjgkjaemb = KIOPGOGHBMD as HGJJGKJAEMB;
		if (hgjjgkjaemb != null)
		{
			this.LNDNNBEMFOG.CNJPDIFLNMN(hgjjgkjaemb);
		}
		CCPLLFGMOOI ccpllfgmooi = KIOPGOGHBMD as CCPLLFGMOOI;
		if (ccpllfgmooi != null)
		{
			this.GFPPLALNECI.CNJPDIFLNMN(ccpllfgmooi);
		}
		MNCAFLPABEC mncaflpabec = KIOPGOGHBMD as MNCAFLPABEC;
		if (mncaflpabec != null)
		{
			this.DGKMJDICLFG.CNJPDIFLNMN(mncaflpabec);
		}
		IBEMCJIHAFJ ibemcjihafj = KIOPGOGHBMD as IBEMCJIHAFJ;
		if (ibemcjihafj != null)
		{
			this.DHHHLDGPALJ.CNJPDIFLNMN(ibemcjihafj);
		}
		PEOJFPPDFGH peojfppdfgh = KIOPGOGHBMD as PEOJFPPDFGH;
		if (peojfppdfgh != null)
		{
			this.AHEJPDFCJBO -= peojfppdfgh.OnEvent;
		}
		LPNGOKIIHPN lpngokiihpn = KIOPGOGHBMD as LPNGOKIIHPN;
		if (lpngokiihpn != null)
		{
			this.LHNBMIOBKAC.CNJPDIFLNMN(lpngokiihpn);
		}
	}

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x0600DB49 RID: 56137 RVA: 0x000547A1 File Offset: 0x000529A1
	// (set) Token: 0x0600DB1A RID: 56090 RVA: 0x000545D9 File Offset: 0x000527D9
	public bool KOIMNBHLOEF { get; set; }

	// Token: 0x0600DB1B RID: 56091 RVA: 0x0054A3B0 File Offset: 0x005485B0
	private string POMNKDHEMNJ()
	{
		int num = 0;
		PNNODLLHJMG.DJIBKHBKFCL.TryGetValue(this.MBBOGGKAFJI.TransportProtocol, out num);
		if (this.MBBOGGKAFJI.TransportProtocol == ConnectionProtocol.Udp && this.KOIMNBHLOEF)
		{
			num = 27000;
		}
		switch (this.MBBOGGKAFJI.TransportProtocol)
		{
		case ConnectionProtocol.Udp:
		case ConnectionProtocol.Tcp:
			return string.Format("{0}:{1}", this.KKAAJNPJNBA, num);
		case ConnectionProtocol.WebSocket:
			return string.Format("ws://{0}:{1}", this.KKAAJNPJNBA, num);
		case ConnectionProtocol.WebSocketSecure:
			return string.Format("ws://{0}:{1}", this.KKAAJNPJNBA, num);
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x0600DB1C RID: 56092 RVA: 0x00054669 File Offset: 0x00052869
	// (set) Token: 0x0600DB29 RID: 56105 RVA: 0x000546F9 File Offset: 0x000528F9
	public PJPJONLOJHN KGKLCBPOMEO { get; private set; }

	// Token: 0x0600DB1D RID: 56093 RVA: 0x0054A474 File Offset: 0x00548674
	private void FEOIDINAMCO(int[] OOLILNGPHOF)
	{
		if (OOLILNGPHOF != null)
		{
			foreach (int num in OOLILNGPHOF)
			{
				if (this.IHOAIEDNILP.AJKBBPEFLGD(num) == null)
				{
					this.IHOAIEDNILP.FACOGGCAGPA(this.JIHCEKPCPKO(string.Empty, num, false, null));
				}
			}
		}
	}

	// Token: 0x0600DB1E RID: 56094 RVA: 0x0054A4D0 File Offset: 0x005486D0
	private void GEDFKEBCMIM(OperationResponse NMBBBKAFHDJ)
	{
		if (NMBBBKAFHDJ.ReturnCode != 0)
		{
			if (NMBBBKAFHDJ.OperationCode == 226)
			{
				this.DGKMJDICLFG.OnJoinRoomFailed(NMBBBKAFHDJ.ReturnCode, NMBBBKAFHDJ.DebugMessage);
			}
			else if (NMBBBKAFHDJ.OperationCode == 227)
			{
				this.DGKMJDICLFG.OnCreateRoomFailed(NMBBBKAFHDJ.ReturnCode, NMBBBKAFHDJ.DebugMessage);
			}
			else if (NMBBBKAFHDJ.OperationCode == 225)
			{
				this.DGKMJDICLFG.OnJoinRandomFailed(NMBBBKAFHDJ.ReturnCode, NMBBBKAFHDJ.DebugMessage);
			}
		}
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x00054964 File Offset: 0x00052B64
	// (set) Token: 0x0600DB1F RID: 56095 RVA: 0x00054671 File Offset: 0x00052871
	public OKMMOLCOKBF HDGIOHLBJKI { get; internal set; }

	// Token: 0x0600DB20 RID: 56096 RVA: 0x0054A568 File Offset: 0x00548768
	protected internal void INMFBBJDLJN(byte HIJMGGKCDLD, object MKANAGHCFCD)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[HIJMGGKCDLD] = MKANAGHCFCD;
		this.MCCGOPPKMON(hashtable, null, null);
	}

	// Token: 0x0600DB21 RID: 56097 RVA: 0x0054A594 File Offset: 0x00548794
	private void EDBEDELNIMC()
	{
		PJPJONLOJHN pjpjonlojhn = this.KGKLCBPOMEO;
		if (pjpjonlojhn != PJPJONLOJHN.NameServer)
		{
			if (pjpjonlojhn != PJPJONLOJHN.MasterServer)
			{
				if (pjpjonlojhn == PJPJONLOJHN.GameServer)
				{
					this.AGAADNLBHCE = MOCMDLAOOBB.DisconnectingFromGameserver;
				}
			}
			else
			{
				this.AGAADNLBHCE = MOCMDLAOOBB.DisconnectingFromMasterserver;
			}
		}
		else
		{
			this.AGAADNLBHCE = MOCMDLAOOBB.DisconnectingFromNameServer;
		}
		this.MBBOGGKAFJI.Disconnect();
	}

	// Token: 0x0600DB23 RID: 56099 RVA: 0x0054A5F4 File Offset: 0x005487F4
	private void HPNILEMHPNE(OperationResponse NMBBBKAFHDJ)
	{
		this.IHOAIEDNILP = this.ILDNKAPHAFA(this.DABODHJPFGP.IKBLJDACJNP, this.DABODHJPFGP.KPCOAOPIGEB);
		this.IHOAIEDNILP.MGEKLLCKPGF = this;
		int fmnfnehjgmo = (int)NMBBBKAFHDJ[254];
		this.MLDCAEPLLKK(fmnfnehjgmo);
		if (NMBBBKAFHDJ.Parameters.ContainsKey(252))
		{
			int[] oolilngphof = (int[])NMBBBKAFHDJ.Parameters[252];
			this.FEOIDINAMCO(oolilngphof);
		}
		Hashtable dfpblahkkkl = (Hashtable)NMBBBKAFHDJ[249];
		Hashtable afbbhkhbhck = (Hashtable)NMBBBKAFHDJ[248];
		this.OILBAMJPFHF(afbbhkhbhck, dfpblahkkkl, 0, 0);
		this.AGAADNLBHCE = MOCMDLAOOBB.Joined;
		byte operationCode = NMBBBKAFHDJ.OperationCode;
		if (operationCode != 227)
		{
			if (operationCode != 226 && operationCode != 225)
			{
			}
		}
		else
		{
			this.DGKMJDICLFG.OnCreatedRoom();
		}
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x0600DB24 RID: 56100 RVA: 0x00054683 File Offset: 0x00052883
	public bool CGCOBKJDFPD
	{
		get
		{
			return this.MBBOGGKAFJI != null && this.AGAADNLBHCE != MOCMDLAOOBB.PeerCreated && this.AGAADNLBHCE != MOCMDLAOOBB.Disconnected;
		}
	}

	// Token: 0x0600DB25 RID: 56101 RVA: 0x0054A6F4 File Offset: 0x005488F4
	protected internal virtual OKMMOLCOKBF IKKOPCFDPOG(string JCIKLDOKOOM, int GNBNKIFDGLJ, bool PPGPHHGMCHK, Hashtable DFPBLAHKKKL)
	{
		return new OKMMOLCOKBF(JCIKLDOKOOM, GNBNKIFDGLJ, PPGPHHGMCHK, DFPBLAHKKKL);
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x0600DB43 RID: 56131 RVA: 0x0005478A File Offset: 0x0005298A
	// (set) Token: 0x0600DB26 RID: 56102 RVA: 0x000546AB File Offset: 0x000528AB
	public int HPHLFHOLCGP { get; internal set; }

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x0600DB27 RID: 56103 RVA: 0x000546B4 File Offset: 0x000528B4
	private string OLDHBJNALPD
	{
		get
		{
			if (this.JEBOPFMOPHC == HPGOLAFBMBL.Auth)
			{
				return null;
			}
			return (this.NCCDOCBKBBE == null) ? null : this.NCCDOCBKBBE.OOCDBPNDEOJ;
		}
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x0600DB7B RID: 56187 RVA: 0x0005494E File Offset: 0x00052B4E
	// (set) Token: 0x0600DB28 RID: 56104 RVA: 0x000546DF File Offset: 0x000528DF
	public string LCCMNONPCBN
	{
		get
		{
			return this.HDGIOHLBJKI.LCCMNONPCBN;
		}
		set
		{
			if (this.HDGIOHLBJKI == null)
			{
				return;
			}
			this.HDGIOHLBJKI.LCCMNONPCBN = value;
		}
	}

	// Token: 0x14000017 RID: 23
	// (add) Token: 0x0600DB2B RID: 56107 RVA: 0x0054A710 File Offset: 0x00548910
	// (remove) Token: 0x0600DB5C RID: 56156 RVA: 0x0054BF6C File Offset: 0x0054A16C
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action<MOCMDLAOOBB, MOCMDLAOOBB> IOJFLLACKJO;

	// Token: 0x0600DB2C RID: 56108 RVA: 0x0005470A File Offset: 0x0005290A
	public void MFMPEIOODCK(bool MKANAGHCFCD)
	{
		this.<BECOAJDPLEL>k__BackingField = MKANAGHCFCD;
	}

	// Token: 0x0600DB2D RID: 56109 RVA: 0x0054A6F4 File Offset: 0x005488F4
	protected internal virtual OKMMOLCOKBF JIHCEKPCPKO(string JCIKLDOKOOM, int GNBNKIFDGLJ, bool PPGPHHGMCHK, Hashtable DFPBLAHKKKL)
	{
		return new OKMMOLCOKBF(JCIKLDOKOOM, GNBNKIFDGLJ, PPGPHHGMCHK, DFPBLAHKKKL);
	}

	// Token: 0x0600DB2E RID: 56110 RVA: 0x0054A748 File Offset: 0x00548948
	public virtual void ANAEGMKPAEA(StatusCode NCDPEJKPILP)
	{
		switch (NCDPEJKPILP)
		{
		case (StatusCode)112:
			goto IL_50A;
		case (StatusCode)113:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.HKKNMABMBEF(OKPEAHBBOKB.CustomAuthenticationFailed);
			this.AGAADNLBHCE = (MOCMDLAOOBB)119;
			this.GFPPLALNECI.BHFCKIELDKH(this.GMILBPCOKPL);
			return;
		case (StatusCode)114:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.DLKLNOLOJNF(null);
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.ClientTimeout;
			this.AGAADNLBHCE = (MOCMDLAOOBB)(-75);
			this.GFPPLALNECI.OnDisconnected(this.GMILBPCOKPL);
			return;
		case (StatusCode)115:
			this.DebugReturn(DebugLevel.ERROR, ". It will be disabled.");
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.HKKNMABMBEF((OKPEAHBBOKB)109);
			this.AGAADNLBHCE = (MOCMDLAOOBB)(-63);
			return;
		case (StatusCode)116:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.DLKLNOLOJNF(null);
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.CustomAuthenticationFailed;
			this.AGAADNLBHCE = (MOCMDLAOOBB)91;
			this.GFPPLALNECI.OIPGDDCEFMK(this.GMILBPCOKPL);
			return;
		case (StatusCode)117:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.DisconnectByServerLogic;
			this.AGAADNLBHCE = (MOCMDLAOOBB)(-38);
			this.GFPPLALNECI.OnDisconnected(this.GMILBPCOKPL);
			return;
		default:
			switch (NCDPEJKPILP)
			{
			case (StatusCode)(-125):
			case (StatusCode)(-124):
				if (this.NCCDOCBKBBE != null)
				{
					this.NCCDOCBKBBE.DLKLNOLOJNF(null);
				}
				this.GMILBPCOKPL = OKPEAHBBOKB.None;
				this.AGAADNLBHCE = (MOCMDLAOOBB)(-27);
				this.GFPPLALNECI.OIPGDDCEFMK(this.GMILBPCOKPL);
				return;
			case (StatusCode)(-123):
				this.OGLEHMOODPG = false;
				if (this.FBNDJNLDFJK() == (MOCMDLAOOBB)31)
				{
					if (this.EFLMACPOPJD().DebugOut >= DebugLevel.OFF)
					{
						this.DebugReturn(DebugLevel.INFO, "ColorFrameReference");
					}
					this.KGKLCBPOMEO = (PJPJONLOJHN)5;
					if (this.NCCDOCBKBBE != null)
					{
						this.NCCDOCBKBBE.DLKLNOLOJNF(null);
					}
				}
				if (this.AGAADNLBHCE == MOCMDLAOOBB.ConnectingToGameserver)
				{
					if (this.EFLMACPOPJD().DebugOut >= DebugLevel.INFO)
					{
						this.DebugReturn(DebugLevel.ERROR, "1.2.643.2.2.35.3");
					}
					this.KGKLCBPOMEO = PJPJONLOJHN.GameServer;
				}
				if (this.FBNDJNLDFJK() == (MOCMDLAOOBB)(-11))
				{
					if (this.EFLMACPOPJD().DebugOut >= DebugLevel.INFO)
					{
						this.DebugReturn(DebugLevel.ALL, "ShowDeath");
					}
					this.KGKLCBPOMEO = PJPJONLOJHN.MasterServer;
					this.GFPPLALNECI.LAJPDOLNFDA();
				}
				if (this.EFLMACPOPJD().TransportProtocol != ConnectionProtocol.Udp)
				{
					if (this.KGKLCBPOMEO == (PJPJONLOJHN)5 || this.JEBOPFMOPHC == HPGOLAFBMBL.Auth)
					{
						this.EFLMACPOPJD().EstablishEncryption();
					}
					return;
				}
				break;
			case (StatusCode)(-122):
			{
				this.MLDCAEPLLKK(-1);
				this.NPGHHMKFHCC = null;
				bool flag = this.IHOAIEDNILP != null;
				if (this.KGKLCBPOMEO == PJPJONLOJHN.MasterServer || this.AGAADNLBHCE == (MOCMDLAOOBB)44 || this.FBNDJNLDFJK() == MOCMDLAOOBB.PeerCreated)
				{
					this.IHOAIEDNILP = null;
				}
				this.NMCOKIEHFDC = false;
				this.OGLEHMOODPG = true;
				if (this.KGKLCBPOMEO == PJPJONLOJHN.GameServer && flag)
				{
					this.DGKMJDICLFG.OnLeftRoom();
				}
				MOCMDLAOOBB mocmdlaoobb = this.FBNDJNLDFJK();
				switch (mocmdlaoobb)
				{
				case (MOCMDLAOOBB)(-23):
				case (MOCMDLAOOBB)(-16):
					this.GHABNCHCAFC();
					goto IL_3A1;
				default:
					if (mocmdlaoobb != MOCMDLAOOBB.PeerCreated)
					{
						if (mocmdlaoobb != MOCMDLAOOBB.Authenticating)
						{
							string empty = string.Empty;
							DebugLevel floplfddmgi = DebugLevel.WARNING;
							object[] array = new object[6];
							array[0] = "_ReflectionBufferSize";
							array[1] = this.AGAADNLBHCE;
							array[7] = "ECDH";
							array[5] = this.KGKLCBPOMEO;
							array[1] = "_Range";
							array[4] = empty;
							this.DebugReturn(floplfddmgi, string.Concat(array));
							if (this.NCCDOCBKBBE != null)
							{
								this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
							}
							this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToMasterserver;
							this.GFPPLALNECI.OIPGDDCEFMK(OKPEAHBBOKB.None);
							goto IL_3A1;
						}
						this.PILFHJMIODO();
						goto IL_3A1;
					}
					break;
				case (MOCMDLAOOBB)(-21):
					break;
				case (MOCMDLAOOBB)(-20):
					goto IL_3A1;
				}
				if (this.NCCDOCBKBBE != null)
				{
					this.NCCDOCBKBBE.DLKLNOLOJNF(null);
				}
				this.AGAADNLBHCE = MOCMDLAOOBB.Authenticating;
				this.GFPPLALNECI.BHFCKIELDKH((OKPEAHBBOKB)115);
				IL_3A1:
				return;
			}
			case (StatusCode)(-121):
				goto IL_50A;
			default:
				return;
			}
			break;
		case (StatusCode)121:
			break;
		}
		if (this.KGKLCBPOMEO == (PJPJONLOJHN)8)
		{
			this.AGAADNLBHCE = MOCMDLAOOBB.DisconnectingFromGameserver;
			if (!this.NMCOKIEHFDC && string.IsNullOrEmpty(this.DCIECCLCEIB))
			{
				this.GPJNFFNJKHN();
			}
		}
		if (this.KGKLCBPOMEO != (PJPJONLOJHN)7 && (this.JEBOPFMOPHC == HPGOLAFBMBL.Auth || this.JEBOPFMOPHC == HPGOLAFBMBL.AuthOnce))
		{
			return;
		}
		if (!this.NMCOKIEHFDC && (!this.NGJJCBLCHHL || !string.IsNullOrEmpty(this.DCIECCLCEIB)))
		{
			this.NMCOKIEHFDC = this.OHCBAMCMDHI();
			if (this.NMCOKIEHFDC)
			{
				this.AGAADNLBHCE = MOCMDLAOOBB.PeerCreated;
			}
			else
			{
				this.DebugReturn(DebugLevel.ERROR, "MD4" + this.AGAADNLBHCE);
			}
		}
		return;
		IL_50A:
		if (this.NCCDOCBKBBE != null)
		{
			this.NCCDOCBKBBE.DLKLNOLOJNF(null);
		}
		this.HKKNMABMBEF(OKPEAHBBOKB.DisconnectByServerReasonUnknown);
		this.AGAADNLBHCE = (MOCMDLAOOBB)(-64);
	}

	// Token: 0x0600DB2F RID: 56111 RVA: 0x00054713 File Offset: 0x00052913
	protected void HKKNMABMBEF(OKPEAHBBOKB MKANAGHCFCD)
	{
		this.<ILCNJJABHOE>k__BackingField = MKANAGHCFCD;
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x0600DB52 RID: 56146 RVA: 0x000545E2 File Offset: 0x000527E2
	// (set) Token: 0x0600DB30 RID: 56112 RVA: 0x0005471C File Offset: 0x0005291C
	public string DCIECCLCEIB { get; private set; }

	// Token: 0x0600DB31 RID: 56113 RVA: 0x0054AC8C File Offset: 0x00548E8C
	private void NGMFGLGMBGP(Dictionary<byte, object> INAEFOKDNOD)
	{
		ADCFDBAEBKI adcfdbaebki = (ADCFDBAEBKI)((byte)INAEFOKDNOD[0]);
		if (adcfdbaebki != ADCFDBAEBKI.PayloadEncryption)
		{
			if (adcfdbaebki != ADCFDBAEBKI.DatagramEncryption)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] encryptionSecret = (byte[])INAEFOKDNOD[1];
			byte[] hmacSecret = (byte[])INAEFOKDNOD[2];
			this.MBBOGGKAFJI.InitDatagramEncryption(encryptionSecret, hmacSecret, false);
		}
		else
		{
			byte[] secret = (byte[])INAEFOKDNOD[1];
			this.MBBOGGKAFJI.InitPayloadEncryption(secret);
		}
	}

	// Token: 0x14000018 RID: 24
	// (add) Token: 0x0600DB53 RID: 56147 RVA: 0x0054B5F8 File Offset: 0x005497F8
	// (remove) Token: 0x0600DB32 RID: 56114 RVA: 0x0054AD0C File Offset: 0x00548F0C
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action<EventData> AHEJPDFCJBO;

	// Token: 0x0600DB33 RID: 56115 RVA: 0x0054AD44 File Offset: 0x00548F44
	public bool JDHCNBKHFOF()
	{
		if (string.IsNullOrEmpty(this.PDEKDKHMPMK))
		{
			this.DebugReturn(DebugLevel.ERROR, "ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).");
			return false;
		}
		if (this.DABODHJPFGP == null)
		{
			this.DebugReturn(DebugLevel.ERROR, "ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.");
			return false;
		}
		if (this.AFIIBBJGFLH == null)
		{
			this.DebugReturn(DebugLevel.ERROR, "ReconnectAndRejoin() failed. It seems the client doesn't have any previous authentication token to re-connect.");
			return false;
		}
		if (this.NCCDOCBKBBE == null)
		{
			this.NCCDOCBKBBE = new AKBLJMMBAKI();
		}
		this.NCCDOCBKBBE.OOCDBPNDEOJ = this.AFIIBBJGFLH;
		if (!string.IsNullOrEmpty(this.PDEKDKHMPMK) && this.DABODHJPFGP != null)
		{
			this.GNGJAKNCNDA = IBGKHAGLJAA.JoinRoom;
			this.DABODHJPFGP.AIAHMFGFNKH = true;
			return this.GOOLLIBFPAA(this.PDEKDKHMPMK, PJPJONLOJHN.GameServer);
		}
		return false;
	}

	// Token: 0x0600DB34 RID: 56116 RVA: 0x0054AE08 File Offset: 0x00549008
	public bool BMHIJENIIJH(EHIFDKPENKA LANBPHNDNJO)
	{
		bool flag = this.KGKLCBPOMEO == PJPJONLOJHN.GameServer;
		LANBPHNDNJO.MBLIFOKBJLH = flag;
		if (!flag)
		{
			this.DABODHJPFGP = LANBPHNDNJO;
		}
		bool flag2 = this.MBBOGGKAFJI.BMHIJENIIJH(LANBPHNDNJO);
		if (flag2)
		{
			this.GNGJAKNCNDA = IBGKHAGLJAA.CreateRoom;
			this.AGAADNLBHCE = MOCMDLAOOBB.Joining;
		}
		return flag2;
	}

	// Token: 0x0600DB35 RID: 56117 RVA: 0x0054A568 File Offset: 0x00548768
	protected internal void BFCNBIOCBBE(byte HIJMGGKCDLD, object MKANAGHCFCD)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[HIJMGGKCDLD] = MKANAGHCFCD;
		this.MCCGOPPKMON(hashtable, null, null);
	}

	// Token: 0x0600DB36 RID: 56118 RVA: 0x00054725 File Offset: 0x00052925
	public virtual bool PCOAJNODKNL(byte GKIPEHINPBK, object KIGOONLDFFC, AGKJONGMIDC FEBNMDKFAFG, SendOptions KPJHAFCHIOC)
	{
		return this.MBBOGGKAFJI != null && this.MBBOGGKAFJI.PCOAJNODKNL(GKIPEHINPBK, KIGOONLDFFC, FEBNMDKFAFG, KPJHAFCHIOC);
	}

	// Token: 0x0600DB37 RID: 56119 RVA: 0x00054744 File Offset: 0x00052944
	public virtual void JCKOCNOCDIE(object PKPPKGHHKIJ)
	{
		this.DebugReturn(DebugLevel.ALL, string.Format("got OnMessage {0}", PKPPKGHHKIJ));
	}

	// Token: 0x0600DB39 RID: 56121 RVA: 0x000545F3 File Offset: 0x000527F3
	public MOCMDLAOOBB FBNDJNLDFJK()
	{
		return this.KELAMIMFMPM;
	}

	// Token: 0x0600DB3A RID: 56122 RVA: 0x00054761 File Offset: 0x00052961
	public void PHCMJMAIFDO(string MKANAGHCFCD)
	{
		this.<MAEIEEPPDDB>k__BackingField = MKANAGHCFCD;
	}

	// Token: 0x0600DB3B RID: 56123 RVA: 0x000545FB File Offset: 0x000527FB
	public string MJNMMFPMFHE()
	{
		return this.<DAFFENMIOGG>k__BackingField;
	}

	// Token: 0x0600DB3C RID: 56124 RVA: 0x0054AE58 File Offset: 0x00549058
	protected internal bool DCOHPOMDGNM(int OCKLBOGBDPH, Hashtable DFPBLAHKKKL, Hashtable GNGODJIJJKF = null, LHFAIKEHMFD MNPOONDKPOK = null)
	{
		if (this.IHOAIEDNILP == null)
		{
			if (this.MBBOGGKAFJI.DebugOut >= DebugLevel.ERROR)
			{
				this.DebugReturn(DebugLevel.ERROR, "OpSetPropertiesOfActor() failed because this client is not in a room currently. State: " + this.AGAADNLBHCE);
			}
			return false;
		}
		if (GNGODJIJJKF == null || GNGODJIJJKF.Count == 0)
		{
			OKMMOLCOKBF okmmolcokbf = this.IHOAIEDNILP.AJKBBPEFLGD(OCKLBOGBDPH);
			if (okmmolcokbf != null)
			{
				okmmolcokbf.DEDOKBOAPCG(DFPBLAHKKKL);
			}
		}
		return this.MBBOGGKAFJI.DCOHPOMDGNM(OCKLBOGBDPH, DFPBLAHKKKL, GNGODJIJJKF, MNPOONDKPOK);
	}

	// Token: 0x0600DB3E RID: 56126 RVA: 0x0054AEDC File Offset: 0x005490DC
	public bool FMOOJKDIICM(string OHMDKONJDLE)
	{
		this.NGJJCBLCHHL = true;
		if (this.AGAADNLBHCE == MOCMDLAOOBB.ConnectedToNameServer)
		{
			this.DCIECCLCEIB = OHMDKONJDLE;
			return this.OHCBAMCMDHI();
		}
		this.MBBOGGKAFJI.Disconnect();
		this.DCIECCLCEIB = OHMDKONJDLE;
		if (this.JEBOPFMOPHC == HPGOLAFBMBL.AuthOnceWss)
		{
			this.LNFKFFLKPPH = this.MBBOGGKAFJI.TransportProtocol;
			this.MBBOGGKAFJI.TransportProtocol = ConnectionProtocol.WebSocketSecure;
		}
		if (!this.MBBOGGKAFJI.Connect(this.FOMNDMLBGJJ, "NameServer", null))
		{
			return false;
		}
		this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToNameServer;
		return true;
	}

	// Token: 0x0600DB3F RID: 56127 RVA: 0x0054AF70 File Offset: 0x00549170
	public virtual void OnEvent(EventData DJLBKBBJMMJ)
	{
		int sender = DJLBKBBJMMJ.Sender;
		OKMMOLCOKBF okmmolcokbf = (this.IHOAIEDNILP == null) ? null : this.IHOAIEDNILP.AJKBBPEFLGD(sender);
		byte code = DJLBKBBJMMJ.Code;
		switch (code)
		{
		case 223:
			if (this.NCCDOCBKBBE == null)
			{
				this.NCCDOCBKBBE = new AKBLJMMBAKI();
			}
			this.NCCDOCBKBBE.OOCDBPNDEOJ = (DJLBKBBJMMJ[221] as string);
			this.AFIIBBJGFLH = this.NCCDOCBKBBE.OOCDBPNDEOJ;
			break;
		case 224:
		{
			string[] array = DJLBKBBJMMJ[213] as string[];
			byte[] array2 = DJLBKBBJMMJ[212] as byte[];
			int[] array3 = DJLBKBBJMMJ[229] as int[];
			int[] array4 = DJLBKBBJMMJ[228] as int[];
			this.NMLJNJJPJDG.Clear();
			for (int i = 0; i < array.Length; i++)
			{
				JIANHCEINKO jianhceinko = new JIANHCEINKO();
				jianhceinko.JMFLIOIAJHA = array[i];
				jianhceinko.LMDGJAKKCEO = (KOJGGEBNMFJ)array2[i];
				jianhceinko.LGFNJMCPHPP = array3[i];
				jianhceinko.BOMKCPDGHBJ = array4[i];
				this.NMLJNJJPJDG.Add(jianhceinko);
			}
			this.DHHHLDGPALJ.OnLobbyStatisticsUpdate(this.NMLJNJJPJDG);
			break;
		}
		default:
			switch (code)
			{
			case 253:
			{
				int num = 0;
				if (DJLBKBBJMMJ.Parameters.ContainsKey(253))
				{
					num = (int)DJLBKBBJMMJ[253];
				}
				Hashtable afbbhkhbhck = null;
				Hashtable dfpblahkkkl = null;
				if (num == 0)
				{
					afbbhkhbhck = (Hashtable)DJLBKBBJMMJ[251];
				}
				else
				{
					dfpblahkkkl = (Hashtable)DJLBKBBJMMJ[251];
				}
				this.OILBAMJPFHF(afbbhkhbhck, dfpblahkkkl, num, sender);
				break;
			}
			case 254:
			{
				bool flag = false;
				if (DJLBKBBJMMJ.Parameters.ContainsKey(233))
				{
					flag = (bool)DJLBKBBJMMJ.Parameters[233];
				}
				if (flag)
				{
					okmmolcokbf.OMDENLCAPGI = true;
				}
				else
				{
					this.IHOAIEDNILP.IMELBBNEAOO(sender);
				}
				if (DJLBKBBJMMJ.Parameters.ContainsKey(203))
				{
					int num2 = (int)DJLBKBBJMMJ[203];
					if (num2 != 0)
					{
						this.IHOAIEDNILP.FAMAJOILPPJ = num2;
						this.LNDNNBEMFOG.OnMasterClientSwitched(this.IHOAIEDNILP.AJKBBPEFLGD(num2));
					}
				}
				this.LNDNNBEMFOG.OnPlayerLeftRoom(okmmolcokbf);
				break;
			}
			case 255:
			{
				Hashtable hashtable = (Hashtable)DJLBKBBJMMJ[249];
				if (okmmolcokbf == null)
				{
					okmmolcokbf = this.JIHCEKPCPKO(string.Empty, sender, false, hashtable);
					this.IHOAIEDNILP.FACOGGCAGPA(okmmolcokbf);
				}
				else
				{
					okmmolcokbf.DEDOKBOAPCG(hashtable);
					okmmolcokbf.OMDENLCAPGI = false;
				}
				if (sender == this.HDGIOHLBJKI.AFJHLMCKOMM)
				{
					int[] oolilngphof = (int[])DJLBKBBJMMJ[252];
					this.FEOIDINAMCO(oolilngphof);
					if (this.GNGJAKNCNDA == IBGKHAGLJAA.JoinOrCreateRoom && this.HDGIOHLBJKI.AFJHLMCKOMM == 1)
					{
						this.DGKMJDICLFG.OnCreatedRoom();
					}
					this.DGKMJDICLFG.OnJoinedRoom();
				}
				else
				{
					this.LNDNNBEMFOG.OnPlayerEnteredRoom(okmmolcokbf);
				}
				break;
			}
			}
			break;
		case 226:
			this.PFBPJIFMAFP = (int)DJLBKBBJMMJ[229];
			this.HPHLFHOLCGP = (int)DJLBKBBJMMJ[228];
			this.LNLDNFGGEAF = (int)DJLBKBBJMMJ[227];
			break;
		case 229:
		case 230:
		{
			List<LDMGFJEMGAF> list = new List<LDMGFJEMGAF>();
			Hashtable hashtable2 = (Hashtable)DJLBKBBJMMJ[222];
			foreach (object obj in hashtable2.Keys)
			{
				string text = (string)obj;
				list.Add(new LDMGFJEMGAF(text, (Hashtable)hashtable2[text]));
			}
			this.DHHHLDGPALJ.OnRoomListUpdate(list);
			break;
		}
		}
		if (this.AHEJPDFCJBO != null)
		{
			this.AHEJPDFCJBO(DJLBKBBJMMJ);
		}
	}

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x0600DB59 RID: 56153 RVA: 0x00054849 File Offset: 0x00052A49
	// (set) Token: 0x0600DB40 RID: 56128 RVA: 0x00054772 File Offset: 0x00052972
	public string OLONLCFBHAN { get; set; }

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x0600DB54 RID: 56148 RVA: 0x00054806 File Offset: 0x00052A06
	// (set) Token: 0x0600DB41 RID: 56129 RVA: 0x00054761 File Offset: 0x00052961
	public string OAEIKHMLDNC { get; set; }

	// Token: 0x0600DB42 RID: 56130 RVA: 0x0005477B File Offset: 0x0005297B
	public bool MPBGILPDEPH(AMFNLONEKCH MFMFDLHNDOE, string ECCNGOCKGEC)
	{
		return this.MBBOGGKAFJI.ONPOPGACKCC(MFMFDLHNDOE, ECCNGOCKGEC);
	}

	// Token: 0x0600DB44 RID: 56132 RVA: 0x00054792 File Offset: 0x00052992
	public bool DIDHEDOCLOP(AMFNLONEKCH MFMFDLHNDOE, string ECCNGOCKGEC)
	{
		return this.MBBOGGKAFJI.DIDHEDOCLOP(MFMFDLHNDOE, ECCNGOCKGEC);
	}

	// Token: 0x0600DB45 RID: 56133 RVA: 0x000547A1 File Offset: 0x000529A1
	public bool ALLGMANNMFN()
	{
		return this.<LJOLEPDFHHG>k__BackingField;
	}

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x000547A9 File Offset: 0x000529A9
	// (set) Token: 0x0600DB85 RID: 56197 RVA: 0x0005470A File Offset: 0x0005290A
	public bool NGJJCBLCHHL { get; set; }

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x0600DB87 RID: 56199 RVA: 0x000549D1 File Offset: 0x00052BD1
	// (set) Token: 0x0600DB47 RID: 56135 RVA: 0x000547B1 File Offset: 0x000529B1
	public string JDHDCECKLLG
	{
		get
		{
			if (this.NCCDOCBKBBE != null)
			{
				return this.NCCDOCBKBBE.JDHDCECKLLG;
			}
			return null;
		}
		set
		{
			if (this.NCCDOCBKBBE == null)
			{
				this.NCCDOCBKBBE = new AKBLJMMBAKI();
			}
			this.NCCDOCBKBBE.JDHDCECKLLG = value;
		}
	}

	// Token: 0x0600DB48 RID: 56136 RVA: 0x0054B3E0 File Offset: 0x005495E0
	private bool OHCBAMCMDHI()
	{
		if (this.JEBOPFMOPHC == HPGOLAFBMBL.Auth)
		{
			return this.MBBOGGKAFJI.AHLCFAEHACC(this.OLONLCFBHAN, this.OAEIKHMLDNC, this.NCCDOCBKBBE, this.DCIECCLCEIB, this.EKLCBBCCFNP && this.KGKLCBPOMEO == PJPJONLOJHN.MasterServer);
		}
		return this.MBBOGGKAFJI.EBOJNIAGPIB(this.OLONLCFBHAN, this.OAEIKHMLDNC, this.NCCDOCBKBBE, this.DCIECCLCEIB, this.NACOAFJONIL, this.LNFKFFLKPPH);
	}

	// Token: 0x0600DB4A RID: 56138 RVA: 0x0054B464 File Offset: 0x00549664
	public bool JAHNHIAMCJL()
	{
		this.NGJJCBLCHHL = true;
		this.DCIECCLCEIB = null;
		if (this.JEBOPFMOPHC == HPGOLAFBMBL.AuthOnceWss)
		{
			this.LNFKFFLKPPH = this.MBBOGGKAFJI.TransportProtocol;
			this.MBBOGGKAFJI.TransportProtocol = ConnectionProtocol.WebSocketSecure;
		}
		if (!this.MBBOGGKAFJI.Connect(this.FOMNDMLBGJJ, "NameServer", this.OLDHBJNALPD))
		{
			return false;
		}
		this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToNameServer;
		return true;
	}

	// Token: 0x0600DB4B RID: 56139 RVA: 0x0054B4D4 File Offset: 0x005496D4
	public bool ANOIKBJGCIB(string KLGGIAFJNDE)
	{
		bool mblifokbjlh = this.KGKLCBPOMEO == PJPJONLOJHN.GameServer;
		EHIFDKPENKA ehifdkpenka = new EHIFDKPENKA();
		this.DABODHJPFGP = ehifdkpenka;
		ehifdkpenka.IKBLJDACJNP = KLGGIAFJNDE;
		ehifdkpenka.MBLIFOKBJLH = mblifokbjlh;
		ehifdkpenka.AIAHMFGFNKH = true;
		bool flag = this.MBBOGGKAFJI.BPEIMOMFHND(ehifdkpenka);
		if (flag)
		{
			this.GNGJAKNCNDA = IBGKHAGLJAA.JoinRoom;
			this.AGAADNLBHCE = MOCMDLAOOBB.Joining;
		}
		return flag;
	}

	// Token: 0x0600DB4C RID: 56140 RVA: 0x0054B530 File Offset: 0x00549730
	private bool GOOLLIBFPAA(string BHFDJEDPCKH, PJPJONLOJHN GGEANGOFCHO)
	{
		if (this.AGAADNLBHCE == MOCMDLAOOBB.Disconnecting)
		{
			this.DebugReturn(DebugLevel.ERROR, "Connect() failed. Can't connect while disconnecting (still). Current state: " + this.AGAADNLBHCE);
			return false;
		}
		bool flag = this.MBBOGGKAFJI.Connect(BHFDJEDPCKH, string.Empty, this.OLDHBJNALPD);
		if (flag)
		{
			if (GGEANGOFCHO != PJPJONLOJHN.NameServer)
			{
				if (GGEANGOFCHO != PJPJONLOJHN.MasterServer)
				{
					if (GGEANGOFCHO == PJPJONLOJHN.GameServer)
					{
						this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToGameserver;
					}
				}
				else
				{
					this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToMasterserver;
				}
			}
			else
			{
				this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToNameServer;
			}
		}
		return flag;
	}

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x0600DB4D RID: 56141 RVA: 0x000547D5 File Offset: 0x000529D5
	public bool PFIDGLHKGLF
	{
		get
		{
			return this.KELAMIMFMPM == MOCMDLAOOBB.Joined;
		}
	}

	// Token: 0x0600DB4E RID: 56142 RVA: 0x0005476A File Offset: 0x0005296A
	public FNLJIBNMNGP EFLMACPOPJD()
	{
		return this.<GEPNADOMEBA>k__BackingField;
	}

	// Token: 0x0600DB4F RID: 56143 RVA: 0x0054B5C8 File Offset: 0x005497C8
	private bool GPJNFFNJKHN()
	{
		return this.KGKLCBPOMEO == PJPJONLOJHN.NameServer && this.MBBOGGKAFJI.GPJNFFNJKHN(this.OLONLCFBHAN);
	}

	// Token: 0x0600DB50 RID: 56144 RVA: 0x000547E1 File Offset: 0x000529E1
	public virtual bool IBLJINGPCGH(byte[] APDIILBPFJJ, byte[] DLBDLLNCHOK)
	{
		return this.MBBOGGKAFJI != null && this.MBBOGGKAFJI.IBLJINGPCGH(APDIILBPFJJ, DLBDLLNCHOK);
	}

	// Token: 0x0600DB55 RID: 56149 RVA: 0x0054B630 File Offset: 0x00549830
	public virtual void OnOperationResponse(OperationResponse NMBBBKAFHDJ)
	{
		if (NMBBBKAFHDJ.Parameters.ContainsKey(221))
		{
			if (this.NCCDOCBKBBE == null)
			{
				this.NCCDOCBKBBE = new AKBLJMMBAKI();
			}
			this.NCCDOCBKBBE.OOCDBPNDEOJ = (NMBBBKAFHDJ[221] as string);
			this.AFIIBBJGFLH = this.NCCDOCBKBBE.OOCDBPNDEOJ;
		}
		byte operationCode = NMBBBKAFHDJ.OperationCode;
		switch (operationCode)
		{
		case 217:
			if (NMBBBKAFHDJ.ReturnCode != 0)
			{
				this.DebugReturn(DebugLevel.ERROR, "GetGameList failed: " + NMBBBKAFHDJ.ToStringFull());
			}
			else
			{
				List<LDMGFJEMGAF> list = new List<LDMGFJEMGAF>();
				Hashtable hashtable = (Hashtable)NMBBBKAFHDJ[222];
				foreach (object obj in hashtable.Keys)
				{
					string text = (string)obj;
					list.Add(new LDMGFJEMGAF(text, (Hashtable)hashtable[text]));
				}
				this.DHHHLDGPALJ.OnRoomListUpdate(list);
			}
			break;
		default:
			if (operationCode == 254)
			{
				this.EDBEDELNIMC();
			}
			break;
		case 219:
			this.LHNBMIOBKAC.KPOCMLNJEMI(NMBBBKAFHDJ);
			break;
		case 220:
			if (NMBBBKAFHDJ.ReturnCode == 32767)
			{
				this.DebugReturn(DebugLevel.ERROR, string.Format("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new object[0]));
				this.GFPPLALNECI.OnCustomAuthenticationFailed("Invalid Authentication");
				this.AGAADNLBHCE = MOCMDLAOOBB.Disconnecting;
				this.LPEEAPJCAMA();
			}
			else if (NMBBBKAFHDJ.ReturnCode != 0)
			{
				this.DebugReturn(DebugLevel.ERROR, string.Concat(new object[]
				{
					"GetRegions failed. Can't provide regions list. Error: ",
					NMBBBKAFHDJ.ReturnCode,
					": ",
					NMBBBKAFHDJ.DebugMessage
				}));
			}
			else
			{
				if (this.GJFLAKEICNB == null)
				{
					this.GJFLAKEICNB = new EDFGDIJHFFE();
				}
				if (this.GJFLAKEICNB.IGKKLJGNIPD)
				{
					this.DebugReturn(DebugLevel.WARNING, "Received an response for OpGetRegions while the RegionHandler is pinging regions already. Skipping this response in favor of completing the current region-pinging.");
					return;
				}
				this.GJFLAKEICNB.DKAFNNFIIMH(NMBBBKAFHDJ);
				this.GFPPLALNECI.OnRegionListReceived(this.GJFLAKEICNB);
			}
			break;
		case 222:
			if (NMBBBKAFHDJ.ReturnCode != 0)
			{
				this.DebugReturn(DebugLevel.ERROR, "OpFindFriends failed: " + NMBBBKAFHDJ.ToStringFull());
				this.NPGHHMKFHCC = null;
			}
			else
			{
				bool[] array = NMBBBKAFHDJ[1] as bool[];
				string[] array2 = NMBBBKAFHDJ[2] as string[];
				List<DPLBBLNJJLD> list2 = new List<DPLBBLNJJLD>(this.NPGHHMKFHCC.Length);
				for (int i = 0; i < this.NPGHHMKFHCC.Length; i++)
				{
					list2.Insert(i, new DPLBBLNJJLD
					{
						JDHDCECKLLG = this.NPGHHMKFHCC[i],
						ELBLAHCLHJP = array2[i],
						OJFHOILMGOK = array[i]
					});
				}
				this.NPGHHMKFHCC = null;
				this.DGKMJDICLFG.OnFriendListUpdate(list2);
			}
			break;
		case 225:
		case 226:
		case 227:
			if (NMBBBKAFHDJ.ReturnCode != 0)
			{
				if (this.KGKLCBPOMEO == PJPJONLOJHN.GameServer)
				{
					this.KIBGMIBJBCF = NMBBBKAFHDJ;
					this.EDBEDELNIMC();
				}
				else
				{
					this.AGAADNLBHCE = ((!this.OGLEHMOODPG) ? MOCMDLAOOBB.ConnectedToMasterserver : MOCMDLAOOBB.JoinedLobby);
					this.GEDFKEBCMIM(NMBBBKAFHDJ);
				}
			}
			else if (this.KGKLCBPOMEO == PJPJONLOJHN.GameServer)
			{
				this.HPNILEMHPNE(NMBBBKAFHDJ);
			}
			else
			{
				this.PDEKDKHMPMK = (string)NMBBBKAFHDJ[230];
				if (this.MBBOGGKAFJI.TransportProtocol == ConnectionProtocol.Udp && this.KOIMNBHLOEF)
				{
					this.PDEKDKHMPMK = this.PDEKDKHMPMK.Replace("5058", "27000").Replace("5055", "27001").Replace("5056", "27002");
				}
				string text2 = NMBBBKAFHDJ[byte.MaxValue] as string;
				if (!string.IsNullOrEmpty(text2))
				{
					this.DABODHJPFGP.IKBLJDACJNP = text2;
				}
				this.EDBEDELNIMC();
			}
			break;
		case 228:
			this.AGAADNLBHCE = MOCMDLAOOBB.ConnectedToMasterserver;
			this.OGLEHMOODPG = false;
			this.DHHHLDGPALJ.OnLeftLobby();
			break;
		case 229:
			this.AGAADNLBHCE = MOCMDLAOOBB.JoinedLobby;
			this.OGLEHMOODPG = true;
			this.DHHHLDGPALJ.OnJoinedLobby();
			break;
		case 230:
		case 231:
			if (NMBBBKAFHDJ.ReturnCode != 0)
			{
				this.DebugReturn(DebugLevel.ERROR, string.Concat(new object[]
				{
					NMBBBKAFHDJ.ToStringFull(),
					" Server: ",
					this.KGKLCBPOMEO,
					" Address: ",
					this.MBBOGGKAFJI.ServerAddress
				}));
				short returnCode = NMBBBKAFHDJ.ReturnCode;
				switch (returnCode)
				{
				case 32753:
					this.GMILBPCOKPL = OKPEAHBBOKB.AuthenticationTicketExpired;
					this.GFPPLALNECI.OnDisconnected(OKPEAHBBOKB.AuthenticationTicketExpired);
					break;
				default:
					if (returnCode != -3)
					{
						if (returnCode == 32767)
						{
							this.GMILBPCOKPL = OKPEAHBBOKB.InvalidAuthentication;
							this.GFPPLALNECI.OnDisconnected(OKPEAHBBOKB.InvalidAuthentication);
						}
					}
					else
					{
						this.GMILBPCOKPL = OKPEAHBBOKB.OperationNotAllowedInCurrentState;
					}
					break;
				case 32755:
					this.GMILBPCOKPL = OKPEAHBBOKB.CustomAuthenticationFailed;
					this.GFPPLALNECI.OnCustomAuthenticationFailed(NMBBBKAFHDJ.DebugMessage);
					break;
				case 32756:
					this.GMILBPCOKPL = OKPEAHBBOKB.InvalidRegion;
					this.GFPPLALNECI.OnDisconnected(OKPEAHBBOKB.InvalidRegion);
					break;
				case 32757:
					this.GMILBPCOKPL = OKPEAHBBOKB.MaxCcuReached;
					this.GFPPLALNECI.OnDisconnected(OKPEAHBBOKB.MaxCcuReached);
					break;
				}
				this.AGAADNLBHCE = MOCMDLAOOBB.Disconnecting;
				this.LPEEAPJCAMA();
			}
			else
			{
				if (this.KGKLCBPOMEO == PJPJONLOJHN.NameServer || this.KGKLCBPOMEO == PJPJONLOJHN.MasterServer)
				{
					if (NMBBBKAFHDJ.Parameters.ContainsKey(225))
					{
						string text3 = (string)NMBBBKAFHDJ.Parameters[225];
						if (!string.IsNullOrEmpty(text3))
						{
							this.JDHDCECKLLG = text3;
							this.HDGIOHLBJKI.JDHDCECKLLG = text3;
							this.DebugReturn(DebugLevel.INFO, string.Format("Received your UserID from server. Updating local value to: {0}", this.JDHDCECKLLG));
						}
					}
					if (NMBBBKAFHDJ.Parameters.ContainsKey(202))
					{
						this.LCCMNONPCBN = (string)NMBBBKAFHDJ.Parameters[202];
						this.DebugReturn(DebugLevel.INFO, string.Format("Received your NickName from server. Updating local value to: {0}", this.LCCMNONPCBN));
					}
					if (NMBBBKAFHDJ.Parameters.ContainsKey(192))
					{
						this.NGMFGLGMBGP((Dictionary<byte, object>)NMBBBKAFHDJ.Parameters[192]);
					}
				}
				if (this.KGKLCBPOMEO == PJPJONLOJHN.NameServer)
				{
					this.DIPGCCEJDLC = (NMBBBKAFHDJ[230] as string);
					if (this.MBBOGGKAFJI.TransportProtocol == ConnectionProtocol.Udp && this.KOIMNBHLOEF)
					{
						this.DIPGCCEJDLC = this.DIPGCCEJDLC.Replace("5058", "27000").Replace("5055", "27001").Replace("5056", "27002");
					}
					if (this.JEBOPFMOPHC == HPGOLAFBMBL.AuthOnceWss)
					{
						this.DebugReturn(DebugLevel.INFO, string.Format("Due to AuthOnceWss, switching TransportProtocol to ExpectedProtocol: {0}.", this.LNFKFFLKPPH));
						this.MBBOGGKAFJI.TransportProtocol = this.LNFKFFLKPPH;
					}
					this.EDBEDELNIMC();
				}
				else if (this.KGKLCBPOMEO == PJPJONLOJHN.MasterServer)
				{
					this.AGAADNLBHCE = MOCMDLAOOBB.ConnectedToMasterserver;
					if (this.KIBGMIBJBCF == null)
					{
						this.GFPPLALNECI.OnConnectedToMaster();
					}
					else
					{
						this.GEDFKEBCMIM(this.KIBGMIBJBCF);
						this.KIBGMIBJBCF = null;
					}
					if (this.JEBOPFMOPHC != HPGOLAFBMBL.Auth)
					{
						this.MBBOGGKAFJI.DEJJPDIMPFO(this.EKLCBBCCFNP);
					}
				}
				else if (this.KGKLCBPOMEO == PJPJONLOJHN.GameServer)
				{
					this.AGAADNLBHCE = MOCMDLAOOBB.Joining;
					if (this.DABODHJPFGP.AIAHMFGFNKH)
					{
						this.DABODHJPFGP.IMAKKNFGNDE = null;
					}
					else
					{
						Hashtable hashtable2 = new Hashtable();
						hashtable2.PGAKKIFNAGD(this.HDGIOHLBJKI.JOMAMFMKKJD);
						hashtable2[byte.MaxValue] = this.HDGIOHLBJKI.LCCMNONPCBN;
						this.DABODHJPFGP.IMAKKNFGNDE = hashtable2;
					}
					this.DABODHJPFGP.MBLIFOKBJLH = true;
					if (this.GNGJAKNCNDA == IBGKHAGLJAA.JoinRoom || this.GNGJAKNCNDA == IBGKHAGLJAA.JoinRandomRoom || this.GNGJAKNCNDA == IBGKHAGLJAA.JoinOrCreateRoom)
					{
						this.MBBOGGKAFJI.BPEIMOMFHND(this.DABODHJPFGP);
					}
					else if (this.GNGJAKNCNDA == IBGKHAGLJAA.CreateRoom)
					{
						this.MBBOGGKAFJI.BMHIJENIIJH(this.DABODHJPFGP);
					}
					break;
				}
				Dictionary<string, object> dictionary = (Dictionary<string, object>)NMBBBKAFHDJ[245];
				if (dictionary != null)
				{
					this.GFPPLALNECI.OnCustomAuthenticationResponse(dictionary);
				}
			}
			break;
		}
		if (this.NBHLMGOHHHA != null)
		{
			this.NBHLMGOHHHA(NMBBBKAFHDJ);
		}
	}

	// Token: 0x0600DB56 RID: 56150 RVA: 0x000546B4 File Offset: 0x000528B4
	private string LMNPCKOBNLF()
	{
		if (this.JEBOPFMOPHC == HPGOLAFBMBL.Auth)
		{
			return null;
		}
		return (this.NCCDOCBKBBE == null) ? null : this.NCCDOCBKBBE.OOCDBPNDEOJ;
	}

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x0600DB57 RID: 56151 RVA: 0x0005480E File Offset: 0x00052A0E
	public string AIMIEJMFFPP
	{
		get
		{
			return this.MBBOGGKAFJI.ServerAddress;
		}
	}

	// Token: 0x0600DB58 RID: 56152 RVA: 0x0005481B File Offset: 0x00052A1B
	private bool PILFHJMIODO()
	{
		if (this.MBBOGGKAFJI.Connect(this.PDEKDKHMPMK, this.OLONLCFBHAN, this.OLDHBJNALPD))
		{
			this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToGameserver;
			return true;
		}
		return false;
	}

	// Token: 0x0600DB5A RID: 56154 RVA: 0x0054AD0C File Offset: 0x00548F0C
	public void ABLBNKFKKLN(Action<EventData> MKANAGHCFCD)
	{
		Action<EventData> action = this.AHEJPDFCJBO;
		Action<EventData> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<EventData>>(ref this.AHEJPDFCJBO, (Action<EventData>)Delegate.Remove(action2, MKANAGHCFCD), action);
		}
		while (action != action2);
	}

	// Token: 0x0600DB5D RID: 56157 RVA: 0x0054BFA4 File Offset: 0x0054A1A4
	public bool KLMLHCFILGB(BKBAEBDKCBF COGCAJFDHHA = null)
	{
		if (COGCAJFDHHA == null)
		{
			COGCAJFDHHA = new BKBAEBDKCBF();
		}
		this.DABODHJPFGP = new EHIFDKPENKA();
		this.DABODHJPFGP.EKPMLGPBGGD = COGCAJFDHHA.ABHOLLLJCMC;
		this.DABODHJPFGP.ONKEAGHGMLG = COGCAJFDHHA.ONKEAGHGMLG;
		bool flag = this.MBBOGGKAFJI.KLMLHCFILGB(COGCAJFDHHA);
		if (flag)
		{
			this.GNGJAKNCNDA = IBGKHAGLJAA.JoinRandomRoom;
			this.AGAADNLBHCE = MOCMDLAOOBB.Joining;
		}
		return flag;
	}

	// Token: 0x0600DB5E RID: 56158 RVA: 0x0054C010 File Offset: 0x0054A210
	public PNNODLLHJMG(ConnectionProtocol EJICODOLPEL = ConnectionProtocol.Udp)
	{
		this.MBBOGGKAFJI = new MJFCNDFGEAJ(this, EJICODOLPEL);
		this.MBBOGGKAFJI.SerializationProtocolType = SerializationProtocol.GpBinaryV18;
		this.HDGIOHLBJKI = this.JIHCEKPCPKO(string.Empty, -1, true, null);
		this.AGAADNLBHCE = MOCMDLAOOBB.PeerCreated;
	}

	// Token: 0x0600DB5F RID: 56159 RVA: 0x00054647 File Offset: 0x00052847
	public void LIJPEHFBENI(AMFNLONEKCH MKANAGHCFCD)
	{
		this.<IKJDIEDJKHP>k__BackingField = MKANAGHCFCD;
	}

	// Token: 0x0600DB60 RID: 56160 RVA: 0x00054851 File Offset: 0x00052A51
	private Hashtable FAFBEBJBGOJ(Hashtable DFPBLAHKKKL, int OCKLBOGBDPH)
	{
		if (DFPBLAHKKKL.ContainsKey(OCKLBOGBDPH))
		{
			return (Hashtable)DFPBLAHKKKL[OCKLBOGBDPH];
		}
		return DFPBLAHKKKL;
	}

	// Token: 0x0600DB62 RID: 56162 RVA: 0x0054C0B0 File Offset: 0x0054A2B0
	public bool KAIIACLBMCL(string FIFGPCNOMOG, object MHFAGBIGJCI, bool JFGOIGPBKJM = false)
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary.Add(209, FIFGPCNOMOG);
		dictionary.Add(208, MHFAGBIGJCI);
		if (JFGOIGPBKJM)
		{
			dictionary.Add(234, 2);
		}
		return this.MBBOGGKAFJI.SendOperation(219, dictionary, SendOptions.SendReliable);
	}

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x0600DB63 RID: 56163 RVA: 0x0005487F File Offset: 0x00052A7F
	// (set) Token: 0x0600DB7D RID: 56189 RVA: 0x0005495B File Offset: 0x00052B5B
	public int LNLDNFGGEAF { get; internal set; }

	// Token: 0x14000019 RID: 25
	// (add) Token: 0x0600DB83 RID: 56195 RVA: 0x0054C694 File Offset: 0x0054A894
	// (remove) Token: 0x0600DB64 RID: 56164 RVA: 0x00549BA8 File Offset: 0x00547DA8
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action<OperationResponse> NBHLMGOHHHA;

	// Token: 0x0600DB65 RID: 56165 RVA: 0x0054C108 File Offset: 0x0054A308
	public void MLDCAEPLLKK(int FMNFNEHJGMO)
	{
		if (this.HDGIOHLBJKI == null)
		{
			this.DebugReturn(DebugLevel.WARNING, string.Format("Local actor is null or not in mActors! mLocalActor: {0} mActors==null: {1} newID: {2}", this.HDGIOHLBJKI, this.IHOAIEDNILP.ENCIHGOKPLA == null, FMNFNEHJGMO));
		}
		if (this.IHOAIEDNILP == null)
		{
			this.HDGIOHLBJKI.MLDCAEPLLKK(FMNFNEHJGMO);
			this.HDGIOHLBJKI.HMHJCCGIDBB = null;
		}
		else
		{
			this.IHOAIEDNILP.IMELBBNEAOO(this.HDGIOHLBJKI);
			this.HDGIOHLBJKI.MLDCAEPLLKK(FMNFNEHJGMO);
			this.IHOAIEDNILP.FACOGGCAGPA(this.HDGIOHLBJKI);
		}
	}

	// Token: 0x0600DB66 RID: 56166 RVA: 0x000547FD File Offset: 0x000529FD
	private void LFELBHABBIA(bool MKANAGHCFCD)
	{
		this.<JHBDJMPHAHK>k__BackingField = MKANAGHCFCD;
	}

	// Token: 0x0600DB67 RID: 56167 RVA: 0x0054C1A8 File Offset: 0x0054A3A8
	public bool AMCLPNMNIEO(BKBAEBDKCBF COGCAJFDHHA = null)
	{
		if (COGCAJFDHHA == null)
		{
			COGCAJFDHHA = new BKBAEBDKCBF();
		}
		this.DABODHJPFGP = new EHIFDKPENKA();
		this.DABODHJPFGP.EKPMLGPBGGD = COGCAJFDHHA.ABHOLLLJCMC;
		this.DABODHJPFGP.ONKEAGHGMLG = COGCAJFDHHA.ONKEAGHGMLG;
		bool flag = this.EFLMACPOPJD().BIHAJAPJFFL(COGCAJFDHHA);
		if (flag)
		{
			this.GNGJAKNCNDA = IBGKHAGLJAA.JoinOrCreateRoom;
			this.AGAADNLBHCE = MOCMDLAOOBB.Authenticating;
		}
		return flag;
	}

	// Token: 0x0600DB69 RID: 56169 RVA: 0x0054A568 File Offset: 0x00548768
	protected internal void DNDEMDIMIKK(byte HIJMGGKCDLD, object MKANAGHCFCD)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[HIJMGGKCDLD] = MKANAGHCFCD;
		this.MCCGOPPKMON(hashtable, null, null);
	}

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x0600DB6A RID: 56170 RVA: 0x00054887 File Offset: 0x00052A87
	public string FOMNDMLBGJJ
	{
		get
		{
			return this.POMNKDHEMNJ();
		}
	}

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x0600DB6B RID: 56171 RVA: 0x0005488F File Offset: 0x00052A8F
	// (set) Token: 0x0600DB70 RID: 56176 RVA: 0x000548DC File Offset: 0x00052ADC
	public int PFBPJIFMAFP { get; internal set; }

	// Token: 0x0600DB6C RID: 56172 RVA: 0x00054897 File Offset: 0x00052A97
	public bool JHIHOMNEJLB(bool FODKHEJDFHA, bool JFGOIGPBKJM = false)
	{
		if (this.IHOAIEDNILP == null || this.KGKLCBPOMEO != PJPJONLOJHN.GameServer || this.AGAADNLBHCE == MOCMDLAOOBB.DisconnectingFromGameserver)
		{
			return false;
		}
		this.AGAADNLBHCE = MOCMDLAOOBB.Leaving;
		return this.MBBOGGKAFJI.JHIHOMNEJLB(FODKHEJDFHA, JFGOIGPBKJM);
	}

	// Token: 0x0600DB6D RID: 56173 RVA: 0x0005478A File Offset: 0x0005298A
	public int JNLBNAINPHI()
	{
		return this.<HHNLIEKCLLM>k__BackingField;
	}

	// Token: 0x0600DB6E RID: 56174 RVA: 0x0054C25C File Offset: 0x0054A45C
	public bool BBPAFGDJHCO()
	{
		if (this.NCCDOCBKBBE == null)
		{
			this.DebugReturn(DebugLevel.ERROR, "_Range");
			this.NCCDOCBKBBE = new AKBLJMMBAKI();
		}
		this.NCCDOCBKBBE.OOCDBPNDEOJ = this.AFIIBBJGFLH;
		return this.GOOLLIBFPAA(this.DIPGCCEJDLC, PJPJONLOJHN.MasterServer);
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x0600DB6F RID: 56175 RVA: 0x000548D4 File Offset: 0x00052AD4
	// (set) Token: 0x0600DB77 RID: 56183 RVA: 0x00054937 File Offset: 0x00052B37
	public string DIPGCCEJDLC { get; set; }

	// Token: 0x0600DB71 RID: 56177 RVA: 0x000548E5 File Offset: 0x00052AE5
	public virtual bool GHABNCHCAFC()
	{
		this.GMILBPCOKPL = OKPEAHBBOKB.ExceptionOnConnect;
		if (this.EFLMACPOPJD().Connect(this.DIPGCCEJDLC, this.OLONLCFBHAN, this.OLDHBJNALPD))
		{
			this.AGAADNLBHCE = (MOCMDLAOOBB)126;
			return true;
		}
		return true;
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x0600DB72 RID: 56178 RVA: 0x0054C2AC File Offset: 0x0054A4AC
	public bool KKKPLNKNLJB
	{
		get
		{
			if (this.MBBOGGKAFJI == null)
			{
				return false;
			}
			MOCMDLAOOBB mocmdlaoobb = this.AGAADNLBHCE;
			switch (mocmdlaoobb)
			{
			case MOCMDLAOOBB.ConnectingToGameserver:
			case MOCMDLAOOBB.Joining:
			case MOCMDLAOOBB.Leaving:
			case MOCMDLAOOBB.ConnectingToMasterserver:
			case MOCMDLAOOBB.Disconnecting:
			case MOCMDLAOOBB.Disconnected:
			case MOCMDLAOOBB.ConnectingToNameServer:
				break;
			default:
				if (mocmdlaoobb != MOCMDLAOOBB.PeerCreated && mocmdlaoobb != MOCMDLAOOBB.Authenticating)
				{
					return true;
				}
				break;
			}
			return false;
		}
	}

	// Token: 0x0600DB73 RID: 56179 RVA: 0x0005491B File Offset: 0x00052B1B
	public virtual bool HNNADEADBOG(byte[] APDIILBPFJJ, byte[] DLBDLLNCHOK)
	{
		return this.EFLMACPOPJD() != null && this.MBBOGGKAFJI.FGJOGOIDCCO(APDIILBPFJJ, DLBDLLNCHOK);
	}

	// Token: 0x0600DB74 RID: 56180 RVA: 0x0054C318 File Offset: 0x0054A518
	public void NPNPNNADFAN(object KIOPGOGHBMD)
	{
		HGJJGKJAEMB hgjjgkjaemb = KIOPGOGHBMD as HGJJGKJAEMB;
		if (hgjjgkjaemb != null)
		{
			this.LNDNNBEMFOG.NPNPNNADFAN(hgjjgkjaemb);
		}
		CCPLLFGMOOI ccpllfgmooi = KIOPGOGHBMD as CCPLLFGMOOI;
		if (ccpllfgmooi != null)
		{
			this.GFPPLALNECI.NPNPNNADFAN(ccpllfgmooi);
		}
		MNCAFLPABEC mncaflpabec = KIOPGOGHBMD as MNCAFLPABEC;
		if (mncaflpabec != null)
		{
			this.DGKMJDICLFG.NPNPNNADFAN(mncaflpabec);
		}
		IBEMCJIHAFJ ibemcjihafj = KIOPGOGHBMD as IBEMCJIHAFJ;
		if (ibemcjihafj != null)
		{
			this.DHHHLDGPALJ.NPNPNNADFAN(ibemcjihafj);
		}
		PEOJFPPDFGH peojfppdfgh = KIOPGOGHBMD as PEOJFPPDFGH;
		if (peojfppdfgh != null)
		{
			this.AHEJPDFCJBO += peojfppdfgh.OnEvent;
		}
		LPNGOKIIHPN lpngokiihpn = KIOPGOGHBMD as LPNGOKIIHPN;
		if (lpngokiihpn != null)
		{
			this.LHNBMIOBKAC.NPNPNNADFAN(lpngokiihpn);
		}
	}

	// Token: 0x0600DB75 RID: 56181 RVA: 0x0054C3C8 File Offset: 0x0054A5C8
	protected internal virtual NPBDDBPFMKB CJOLJIPBOGN(string KLGGIAFJNDE, LLLFNDLGCML KFBDMELMDID)
	{
		return new NPBDDBPFMKB(KLGGIAFJNDE, KFBDMELMDID, false);
	}

	// Token: 0x0600DB76 RID: 56182 RVA: 0x00549B84 File Offset: 0x00547D84
	public bool ACAGFKPPILM(Hashtable CMAGHKKIJHO, Hashtable GNGODJIJJKF = null, LHFAIKEHMFD MNPOONDKPOK = null)
	{
		Hashtable hashtable = new Hashtable();
		hashtable.MOAFPHGNMHL(CMAGHKKIJHO);
		return this.MCCGOPPKMON(hashtable, GNGODJIJJKF, MNPOONDKPOK);
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x00054940 File Offset: 0x00052B40
	public bool PFONKJJGDBJ
	{
		get
		{
			return this.NPGHHMKFHCC != null;
		}
	}

	// Token: 0x0600DB79 RID: 56185 RVA: 0x0054C3E0 File Offset: 0x0054A5E0
	public bool BOMLCKCAOON(string[] EEEAEOGANCM)
	{
		if (this.MBBOGGKAFJI == null)
		{
			this.DebugReturn(DebugLevel.WARNING, "OpFindFriends aborted: LoadBalancingPeer is null.");
			return false;
		}
		if (this.PFONKJJGDBJ || this.KGKLCBPOMEO != PJPJONLOJHN.MasterServer)
		{
			this.DebugReturn(DebugLevel.WARNING, "OpFindFriends skipped: already fetching friends list.");
			return false;
		}
		if (EEEAEOGANCM == null || EEEAEOGANCM.Length == 0)
		{
			this.DebugReturn(DebugLevel.ERROR, "OpFindFriends skipped: friendsToFind array is null or empty.");
			return false;
		}
		if (EEEAEOGANCM.Length > 512)
		{
			this.DebugReturn(DebugLevel.ERROR, string.Format("OpFindFriends skipped: friendsToFind array exceeds allowed length of {0}.", 512));
			return false;
		}
		List<string> list = new List<string>(EEEAEOGANCM.Length);
		for (int i = 0; i < EEEAEOGANCM.Length; i++)
		{
			string text = EEEAEOGANCM[i];
			if (string.IsNullOrEmpty(text))
			{
				this.DebugReturn(DebugLevel.WARNING, string.Format("friendsToFind array contains a null or empty UserId, element at position {0} skipped.", i));
			}
			else if (text.Equals(this.JDHDCECKLLG))
			{
				this.DebugReturn(DebugLevel.WARNING, string.Format("friendsToFind array contains local player's UserId \"{0}\", element at position {1} skipped.", text, i));
			}
			else if (list.Contains(text))
			{
				this.DebugReturn(DebugLevel.WARNING, string.Format("friendsToFind array contains duplicate UserId \"{0}\", element at position {1} skipped.", text, i));
			}
			else
			{
				list.Add(text);
			}
		}
		if (list.Count == 0)
		{
			this.DebugReturn(DebugLevel.ERROR, "OpFindFriends skipped: friends list to find is empty.");
			return false;
		}
		string[] array = list.ToArray();
		bool flag = this.MBBOGGKAFJI.BOMLCKCAOON(array);
		this.NPGHHMKFHCC = ((!flag) ? null : array);
		return flag;
	}

	// Token: 0x0600DB7A RID: 56186 RVA: 0x0054C55C File Offset: 0x0054A75C
	public bool NIOJGGJINHE(EHIFDKPENKA LANBPHNDNJO)
	{
		bool flag = this.KGKLCBPOMEO == PJPJONLOJHN.GameServer;
		LANBPHNDNJO.JIELBJCMIIH = true;
		LANBPHNDNJO.MBLIFOKBJLH = flag;
		if (!flag)
		{
			this.DABODHJPFGP = LANBPHNDNJO;
		}
		bool flag2 = this.MBBOGGKAFJI.BPEIMOMFHND(LANBPHNDNJO);
		if (flag2)
		{
			this.GNGJAKNCNDA = IBGKHAGLJAA.JoinOrCreateRoom;
			this.AGAADNLBHCE = MOCMDLAOOBB.Joining;
		}
		return flag2;
	}

	// Token: 0x0600DB7C RID: 56188 RVA: 0x0054C5B0 File Offset: 0x0054A7B0
	public bool LCHFMOKNMBP(AMFNLONEKCH IGCIADNDCBC)
	{
		if (!this.KKKPLNKNLJB || this.KGKLCBPOMEO != PJPJONLOJHN.MasterServer)
		{
			this.DebugReturn(DebugLevel.ERROR, string.Concat(new object[]
			{
				"OpJoinLobby is only allowed when connected to a Master Server. Current Server: ",
				this.KGKLCBPOMEO,
				", current State: ",
				this.AGAADNLBHCE
			}));
			return false;
		}
		if (IGCIADNDCBC == null)
		{
			IGCIADNDCBC = AMFNLONEKCH.DHEBOGBALOL;
		}
		bool flag = this.MBBOGGKAFJI.LCHFMOKNMBP(IGCIADNDCBC);
		if (flag)
		{
			this.IMLJOLPDBFJ = IGCIADNDCBC;
			this.AGAADNLBHCE = MOCMDLAOOBB.JoiningLobby;
		}
		return flag;
	}

	// Token: 0x0600DB7F RID: 56191 RVA: 0x0054C3C8 File Offset: 0x0054A5C8
	protected internal virtual NPBDDBPFMKB ILDNKAPHAFA(string KLGGIAFJNDE, LLLFNDLGCML KFBDMELMDID)
	{
		return new NPBDDBPFMKB(KLGGIAFJNDE, KFBDMELMDID, false);
	}

	// Token: 0x0600DB80 RID: 56192 RVA: 0x0005496C File Offset: 0x00052B6C
	public bool PCMHHKAKMDF()
	{
		return this.EFLMACPOPJD().IOCOAJKMGBE();
	}

	// Token: 0x0600DB81 RID: 56193 RVA: 0x00054979 File Offset: 0x00052B79
	public virtual bool GOOLLIBFPAA()
	{
		this.GMILBPCOKPL = OKPEAHBBOKB.None;
		if (this.MBBOGGKAFJI.Connect(this.DIPGCCEJDLC, this.OLONLCFBHAN, this.OLDHBJNALPD))
		{
			this.AGAADNLBHCE = MOCMDLAOOBB.ConnectingToMasterserver;
			return true;
		}
		return false;
	}

	// Token: 0x0600DB82 RID: 56194 RVA: 0x0054C644 File Offset: 0x0054A844
	public bool ALLJNHANBHL()
	{
		if (this.NCCDOCBKBBE == null)
		{
			this.DebugReturn(DebugLevel.WARNING, "ReconnectToMaster() with AuthValues == null is not correct!");
			this.NCCDOCBKBBE = new AKBLJMMBAKI();
		}
		this.NCCDOCBKBBE.OOCDBPNDEOJ = this.AFIIBBJGFLH;
		return this.GOOLLIBFPAA(this.DIPGCCEJDLC, PJPJONLOJHN.MasterServer);
	}

	// Token: 0x0600DB84 RID: 56196 RVA: 0x0054C6CC File Offset: 0x0054A8CC
	public virtual void DebugReturn(DebugLevel FLOPLFDDMGI, string PKPPKGHHKIJ)
	{
		if (FLOPLFDDMGI == DebugLevel.ERROR)
		{
			UnityEngine.Debug.LogError(PKPPKGHHKIJ);
		}
		else if (FLOPLFDDMGI == DebugLevel.WARNING)
		{
			UnityEngine.Debug.LogWarning(PKPPKGHHKIJ);
		}
		else if (FLOPLFDDMGI == DebugLevel.INFO)
		{
			UnityEngine.Debug.Log(PKPPKGHHKIJ);
		}
		else if (FLOPLFDDMGI == DebugLevel.ALL)
		{
			UnityEngine.Debug.Log(PKPPKGHHKIJ);
		}
	}

	// Token: 0x0600DB86 RID: 56198 RVA: 0x000549AF File Offset: 0x00052BAF
	public void LPEEAPJCAMA()
	{
		if (this.AGAADNLBHCE != MOCMDLAOOBB.Disconnected)
		{
			this.AGAADNLBHCE = MOCMDLAOOBB.Disconnecting;
			this.MBBOGGKAFJI.Disconnect();
		}
	}

	// Token: 0x0600DB88 RID: 56200 RVA: 0x0005478A File Offset: 0x0005298A
	public int OINPIDNMCNH()
	{
		return this.<HHNLIEKCLLM>k__BackingField;
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x0600DB8A RID: 56202 RVA: 0x000549EB File Offset: 0x00052BEB
	// (set) Token: 0x0600DB89 RID: 56201 RVA: 0x00054713 File Offset: 0x00052913
	public OKPEAHBBOKB GMILBPCOKPL { get; protected set; }

	// Token: 0x0600DB8B RID: 56203 RVA: 0x0054C71C File Offset: 0x0054A91C
	public virtual void OnStatusChanged(StatusCode NCDPEJKPILP)
	{
		switch (NCDPEJKPILP)
		{
		case StatusCode.ExceptionOnReceive:
			goto IL_50A;
		case StatusCode.TimeoutDisconnect:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.ClientTimeout;
			this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
			this.GFPPLALNECI.OnDisconnected(this.GMILBPCOKPL);
			return;
		case StatusCode.DisconnectByServer:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.ServerTimeout;
			this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
			this.GFPPLALNECI.OnDisconnected(this.GMILBPCOKPL);
			return;
		case StatusCode.DisconnectByServerUserLimit:
			this.DebugReturn(DebugLevel.ERROR, "The Photon license's CCU Limit was reached. Server rejected this connection. Wait and re-try.");
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.MaxCcuReached;
			this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
			return;
		case StatusCode.DisconnectByServerLogic:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.DisconnectByServerLogic;
			this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
			this.GFPPLALNECI.OnDisconnected(this.GMILBPCOKPL);
			return;
		case StatusCode.DisconnectByServerReasonUnknown:
			if (this.NCCDOCBKBBE != null)
			{
				this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
			}
			this.GMILBPCOKPL = OKPEAHBBOKB.DisconnectByServerReasonUnknown;
			this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
			this.GFPPLALNECI.OnDisconnected(this.GMILBPCOKPL);
			return;
		default:
			switch (NCDPEJKPILP)
			{
			case StatusCode.SecurityExceptionOnConnect:
			case StatusCode.ExceptionOnConnect:
				if (this.NCCDOCBKBBE != null)
				{
					this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
				}
				this.GMILBPCOKPL = OKPEAHBBOKB.ExceptionOnConnect;
				this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
				this.GFPPLALNECI.OnDisconnected(this.GMILBPCOKPL);
				return;
			case StatusCode.Connect:
				this.OGLEHMOODPG = false;
				if (this.AGAADNLBHCE == MOCMDLAOOBB.ConnectingToNameServer)
				{
					if (this.MBBOGGKAFJI.DebugOut >= DebugLevel.ALL)
					{
						this.DebugReturn(DebugLevel.ALL, "Connected to nameserver.");
					}
					this.KGKLCBPOMEO = PJPJONLOJHN.NameServer;
					if (this.NCCDOCBKBBE != null)
					{
						this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
					}
				}
				if (this.AGAADNLBHCE == MOCMDLAOOBB.ConnectingToGameserver)
				{
					if (this.MBBOGGKAFJI.DebugOut >= DebugLevel.ALL)
					{
						this.DebugReturn(DebugLevel.ALL, "Connected to gameserver.");
					}
					this.KGKLCBPOMEO = PJPJONLOJHN.GameServer;
				}
				if (this.AGAADNLBHCE == MOCMDLAOOBB.ConnectingToMasterserver)
				{
					if (this.MBBOGGKAFJI.DebugOut >= DebugLevel.ALL)
					{
						this.DebugReturn(DebugLevel.ALL, "Connected to masterserver.");
					}
					this.KGKLCBPOMEO = PJPJONLOJHN.MasterServer;
					this.GFPPLALNECI.OnConnected();
				}
				if (this.MBBOGGKAFJI.TransportProtocol != ConnectionProtocol.WebSocketSecure)
				{
					if (this.KGKLCBPOMEO == PJPJONLOJHN.NameServer || this.JEBOPFMOPHC == HPGOLAFBMBL.Auth)
					{
						this.MBBOGGKAFJI.EstablishEncryption();
					}
					return;
				}
				break;
			case StatusCode.Disconnect:
			{
				this.MLDCAEPLLKK(-1);
				this.NPGHHMKFHCC = null;
				bool flag = this.IHOAIEDNILP != null;
				if (this.KGKLCBPOMEO == PJPJONLOJHN.GameServer || this.AGAADNLBHCE == MOCMDLAOOBB.Disconnecting || this.AGAADNLBHCE == MOCMDLAOOBB.PeerCreated)
				{
					this.IHOAIEDNILP = null;
				}
				this.NMCOKIEHFDC = false;
				this.OGLEHMOODPG = false;
				if (this.KGKLCBPOMEO == PJPJONLOJHN.GameServer && flag)
				{
					this.DGKMJDICLFG.OnLeftRoom();
				}
				MOCMDLAOOBB mocmdlaoobb = this.AGAADNLBHCE;
				switch (mocmdlaoobb)
				{
				case MOCMDLAOOBB.DisconnectingFromGameserver:
				case MOCMDLAOOBB.DisconnectingFromNameServer:
					this.GOOLLIBFPAA();
					goto IL_3A1;
				default:
					if (mocmdlaoobb != MOCMDLAOOBB.PeerCreated)
					{
						if (mocmdlaoobb != MOCMDLAOOBB.DisconnectingFromMasterserver)
						{
							string empty = string.Empty;
							this.DebugReturn(DebugLevel.WARNING, string.Concat(new object[]
							{
								"Got a unexpected Disconnect in LoadBalancingClient State: ",
								this.AGAADNLBHCE,
								". Server: ",
								this.KGKLCBPOMEO,
								" Trace: ",
								empty
							}));
							if (this.NCCDOCBKBBE != null)
							{
								this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
							}
							this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
							this.GFPPLALNECI.OnDisconnected(OKPEAHBBOKB.None);
							goto IL_3A1;
						}
						this.PILFHJMIODO();
						goto IL_3A1;
					}
					break;
				case MOCMDLAOOBB.Disconnecting:
					break;
				case MOCMDLAOOBB.Disconnected:
					goto IL_3A1;
				}
				if (this.NCCDOCBKBBE != null)
				{
					this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
				}
				this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
				this.GFPPLALNECI.OnDisconnected(OKPEAHBBOKB.DisconnectByClientLogic);
				IL_3A1:
				return;
			}
			case StatusCode.Exception:
				goto IL_50A;
			default:
				return;
			}
			break;
		case StatusCode.EncryptionEstablished:
			break;
		}
		if (this.KGKLCBPOMEO == PJPJONLOJHN.NameServer)
		{
			this.AGAADNLBHCE = MOCMDLAOOBB.ConnectedToNameServer;
			if (!this.NMCOKIEHFDC && string.IsNullOrEmpty(this.DCIECCLCEIB))
			{
				this.GPJNFFNJKHN();
			}
		}
		if (this.KGKLCBPOMEO != PJPJONLOJHN.NameServer && (this.JEBOPFMOPHC == HPGOLAFBMBL.AuthOnce || this.JEBOPFMOPHC == HPGOLAFBMBL.AuthOnceWss))
		{
			return;
		}
		if (!this.NMCOKIEHFDC && (!this.NGJJCBLCHHL || !string.IsNullOrEmpty(this.DCIECCLCEIB)))
		{
			this.NMCOKIEHFDC = this.OHCBAMCMDHI();
			if (this.NMCOKIEHFDC)
			{
				this.AGAADNLBHCE = MOCMDLAOOBB.Authenticating;
			}
			else
			{
				this.DebugReturn(DebugLevel.ERROR, "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: " + this.AGAADNLBHCE);
			}
		}
		return;
		IL_50A:
		if (this.NCCDOCBKBBE != null)
		{
			this.NCCDOCBKBBE.OOCDBPNDEOJ = null;
		}
		this.GMILBPCOKPL = OKPEAHBBOKB.Exception;
		this.AGAADNLBHCE = MOCMDLAOOBB.Disconnected;
	}

	// Token: 0x04001BAB RID: 7083
	private bool NMCOKIEHFDC;

	// Token: 0x04001BAC RID: 7084
	public HPGOLAFBMBL JEBOPFMOPHC;

	// Token: 0x04001BAD RID: 7085
	public ADCFDBAEBKI NACOAFJONIL;

	// Token: 0x04001BAE RID: 7086
	public ConnectionProtocol LNFKFFLKPPH;

	// Token: 0x04001BAF RID: 7087
	private string AFIIBBJGFLH;

	// Token: 0x04001BB1 RID: 7089
	public string KKAAJNPJNBA = "ns.exitgames.com";

	// Token: 0x04001BB2 RID: 7090
	public string PKAPNMFEJMP = "http://ns.exitgames.com:80/photon/n";

	// Token: 0x04001BB3 RID: 7091
	private static readonly Dictionary<ConnectionProtocol, int> DJIBKHBKFCL = new Dictionary<ConnectionProtocol, int>
	{
		{
			ConnectionProtocol.Udp,
			5058
		},
		{
			ConnectionProtocol.Tcp,
			4533
		},
		{
			ConnectionProtocol.WebSocket,
			9093
		},
		{
			ConnectionProtocol.WebSocketSecure,
			19093
		}
	};

	// Token: 0x04001BB8 RID: 7096
	private MOCMDLAOOBB KELAMIMFMPM;

	// Token: 0x04001BBC RID: 7100
	public MGDJOKMIIEB GFPPLALNECI = new MGDJOKMIIEB();

	// Token: 0x04001BBD RID: 7101
	public BOPNKJILIBE DGKMJDICLFG = new BOPNKJILIBE();

	// Token: 0x04001BBE RID: 7102
	internal EFOCEKMKNMF LNDNNBEMFOG = new EFOCEKMKNMF();

	// Token: 0x04001BBF RID: 7103
	internal DIJNBGAKGDL DHHHLDGPALJ = new DIJNBGAKGDL();

	// Token: 0x04001BC0 RID: 7104
	internal NJLGKKJNFNF LHNBMIOBKAC = new NJLGKKJNFNF();

	// Token: 0x04001BC4 RID: 7108
	public bool EKLCBBCCFNP;

	// Token: 0x04001BC5 RID: 7109
	private readonly List<JIANHCEINKO> NMLJNJJPJDG = new List<JIANHCEINKO>();

	// Token: 0x04001BCB RID: 7115
	private IBGKHAGLJAA GNGJAKNCNDA;

	// Token: 0x04001BCC RID: 7116
	private EHIFDKPENKA DABODHJPFGP;

	// Token: 0x04001BCD RID: 7117
	private OperationResponse KIBGMIBJBCF;

	// Token: 0x04001BCE RID: 7118
	private const int DAOAJGLAADJ = 512;

	// Token: 0x04001BCF RID: 7119
	private string[] NPGHHMKFHCC;

	// Token: 0x04001BD1 RID: 7121
	public EDFGDIJHFFE GJFLAKEICNB;
}
