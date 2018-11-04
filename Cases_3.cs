namespace Pony{ //xb9d8bb5e6df032aa_
    using System;
    public class Program{ //x1110bdd110cdcea4_
        public Program() : base(){}

        public static string Fun2 (string peremen_1, int peremen_2){
            ushort usht=(ushort)peremen_2;;
            int i=0;
            char[] arrch=new char[peremen_1.Length / 4];
            ushort usht1;
            string str;
            for(i=0; i<(peremen_1.Length/4); i++){
                usht1=(ushort)((((peremen_1[4*i]-'a')+((peremen_1[(4*i)+1]-'a') << '\u0004'))+((peremen_1[(4*i)+2]-'a') << '\u0008'))+((peremen_1[(4*i)+3]-'a') << '\u000c'));
                usht1-=usht;
                arrch[i]=(char)usht1;
                usht+=1789;
            }
            str=new string(arrch);
            return str;
        }

        public static void Main(){
            Console.WriteLine(Fun2("eflohgcpkgjpegaapahapboajbfbdbmbhedcbekcgfbdkphdlepdgegekdnepcefhdlfiobggcjgadahd"+
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