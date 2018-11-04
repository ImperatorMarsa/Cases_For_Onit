namespace xb9d8bb5e6df032aa{ //xb9d8bb5e6df032aa_
    using System;
    public class x1110bdd110cdcea4{ //x1110bdd110cdcea4_
        public x1110bdd110cdcea4() : base(){}

        public static string _xaacba899487bce8c (string x5e99b576d2530d13, int x2710752c36f2d14b){
            ushort usht=(ushort)x2710752c36f2d14b;;
            int i=0;
            char[] arrch=new char[x5e99b576d2530d13.Length / 4];
            ushort usht1;
            string str;

            for(i=0; i<(x5e99b576d2530d13.Length/4); i++){
                usht1=(ushort)((((x5e99b576d2530d13[4*i]-'a')+((x5e99b576d2530d13[(4*i)+1]-'a') << '\u0004'))+((x5e99b576d2530d13[(4*i)+2]-'a') << '\u0008'))+((x5e99b576d2530d13[(4*i)+3]-'a')<<'\u000c'));
                usht1-=usht;
                arrch[i]=(char)usht1;
                usht+=1789;
            }
            str=new string(arrch);
            return str;
        }
        public static void Main(){
            Console.WriteLine(_xaacba899487bce8c("eflohgcpkgjpegaapahapboajbfbdbmbhedcbekcgfbdkphdlepdgegekdnepcefhdlfiobggcjgadahd"+
                                   "chhmnnhncfiobmiibdjanjjcoakkmhklapkfaglkbnloldmcalmkacngpinfppnepgomknojpeplolpf"+
                                   "pcajojamoabonhbhjobmnfccnmcboddlikdnmbedniegmpeemgfamnfhiegghlghkchiljhglainlhih"+
                                   "goififjdkmjnkdkalkkmkblffilehplojgmeknmjeennjlnmicomijojiapkdhpihopaifaiimapgdbe"+
                                   "ikblhbcfcicegpceggdmbndmgeeoflecgcfhgjflfagkahgicogcdfhfcmhopcipekiaebjkdijeepje"+
                                   "dgkmomkaeelpcllpccmmcjmnnpmmbhnmboneneocbmoomcppakpnababbiadapaibgbmlmbiaecmpkcd"+
                                   "lbddmidnkpdnpgemonehoefaplfmocgpnjgloahfjhhdnohdofimimimndjknkjembkcnikbnpkpmglh"+
                                   "mnlciemlflmifcnekjnhlaoklhocgoomkfpblmpmkdakkkadfbbakibckpbmjgckincmiedcildbjcea"+
                                   "ijeidafbihflhofchfgbhmghhdhjhkhigbidhiinbpioggjggnjebekfflkhfclofjljeamhehmoeome"+
                                   "efnmplnnedoodkoidbpaphpbeppmdgaadnafcebnclbonbcacjcgcadmbhdlbodnbfebbmejmcfhakfb"+
                                   "bbgeaignlognpfhganhcaeifalihpbjjpijnppjkogkcknkepelpollcocmeojmknanajhnbooncnfom"+
                                   "mmoeidpemkpnmbajmiammpahmgbbmnbllecpllcjgcdpkjdblaeaghegloejkffmkmfgkdgbfkgcjbha"+
                                   "jihojphkigioinioiejmiljgicklhjkbialeihlncolkhfmjhmmdhdnlgkndgboofiomgpoiggpacnpp"+
                                   "aeabelamfcblejbdaacefhcfeocpdfdhpldaedekdkemdbfgdifldpffofgecngecehiclhiccincjid"+
                                   "npiechjmbojkmekoamkjadlfbklolamhaimbapmipfnhpmnnpdoppkooobpgkipdpppcpgagonanneba"+
                                   "olbcoccinjcoiadmmhdgnodjmfecimeomdfomkfnlbglligfmpgjlghllnhbleihglinkcjpkjjekakk"+
                                   "khkkkokckfldjmldkdmfjkmijbnejinbfpnaegoggnoaiephdlpnicaaijadiablchbphobggfcahmcd"+
                                   "hddmbkdkfbeegiedbpeffgffgnfofegmelgcfchefjhheaikehigeoifpejidmjoddkodkkjoallcilj"+
                                   "dplbcgmjcnmpceniblniccokbjonbapjbhpennpfmeacbmaladbbakbkpacjaicipocalfdapmdjpdef"+
                                   "pkeipbfcoifbopfpoggijngkoehfolhpicibojimnajpmhjbnojhmfknhmkomdlplkljlbmbhimklpme"+
                                   "lgnglnnaleofllopfcpojjpojaackhackoahkfblfmb", 7400187));
        }
    }
}