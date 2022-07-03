<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:mission" prefix="nc1mission" />
  <iso:pattern>
    <iso:title>NC1_Mission validation rules</iso:title>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/actionTask/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26373-en">NC1_Mission.5: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (../type=1) then matches(.,':G.T.GAS---') else true()" diagnostics="D26374-en">NC1_Mission.13: Pour une action tactique de type 1 (APPUI), le code symbole doit valoir G*T*GAS---***** .</iso:assert>
      <iso:assert test="if (../type=2) then matches(.,':G.T.GAS---') else true()" diagnostics="D26375-en">NC1_Mission.13: Pour une action tactique de type 2 (APPUI RECIPROQUE), le code symbole doit valoir G*T*GAS---***** .</iso:assert>
      <iso:assert test="if (../type=3) then matches(.,':G.C.MOLAS-') else true()" diagnostics="D26376-en">NC1_Mission.13: Pour une action tactique de type 3 (MENER UN ASSAUT), le code symbole doit valoir G*C*MOLAS-***** .</iso:assert>
      <iso:assert test="if (../type=4) then matches(.,':G.C.MOLAS-') else true()" diagnostics="D26377-en">NC1_Mission.13: Pour une action tactique de type 4 (ATTAQUE), le code symbole doit valoir G*C*MOLAS-***** .</iso:assert>
      <iso:assert test="if (../type=5) then matches(.,':G.T.GB----') else true()" diagnostics="D26378-en">NC1_Mission.13: Pour une action tactique de type 5 (BARRAGE), le code symbole doit valoir G*T*GB----***** .</iso:assert>
      <iso:assert test="if (../type=6) then matches(.,':G.T.GB----') else true()" diagnostics="D26379-en">NC1_Mission.13: Pour une action tactique de type 6 (COUP D'ARRET), le code symbole doit valoir G*T*GB----***** .</iso:assert>
      <iso:assert test="if (../type=7) then matches(.,':G.T.GK----') else true()" diagnostics="D26380-en">NC1_Mission.13: Pour une action tactique de type 7 (CONTRE-ATTAQUE), le code symbole doit valoir G*T*GK----***** .</iso:assert>
      <iso:assert test="if (../type=8) then matches(.,':G.T.GKF---') else true()" diagnostics="D26381-en">NC1_Mission.13: Pour une action tactique de type 8 (CONTRE-BATTERIE), le code symbole doit valoir G*T*GKF---***** .</iso:assert>
      <iso:assert test="if (../type=9) then matches(.,':G.T.GW----') else true()" diagnostics="D26382-en">NC1_Mission.13: Pour une action tactique de type 9 (COMBAT D'USURE), le code symbole doit valoir G*T*GW----***** .</iso:assert>
      <iso:assert test="if (../type=10) then matches(.,':G.T.GO----') else true()" diagnostics="D26383-en">NC1_Mission.13: Pour une action tactique de type 10 (CONTROLER), le code symbole doit valoir G*T*GO----***** .</iso:assert>
      <iso:assert test="if (../type=11) then matches(.,':G.T.GSC---') else true()" diagnostics="D26384-en">NC1_Mission.13: Pour une action tactique de type 11 (COUVRIR), le code symbole doit valoir G*T*GSC---***** .</iso:assert>
      <iso:assert test="if (../type=12) then matches(.,':G.C.MOLAS-') else true()" diagnostics="D26385-en">NC1_Mission.13: Pour une action tactique de type 12 (PRENDRE CONTACT), le code symbole doit valoir G*C*MOLAS-***** .</iso:assert>
      <iso:assert test="if (../type=13) then matches(.,':G.T.GS----') else true()" diagnostics="D26386-en">NC1_Mission.13: Pour une action tactique de type 13 (CONTROLE DE ZONE), le code symbole doit valoir G*T*GS----***** .</iso:assert>
      <iso:assert test="if (../type=14) then matches(.,':G.T.GI----') else true()" diagnostics="D26387-en">NC1_Mission.13: Pour une action tactique de type 14 (DEFENSE D'ARRET), le code symbole doit valoir G*T*GI----***** .</iso:assert>
      <iso:assert test="if (../type=15) then matches(.,':G.T.GB----') else true()" diagnostics="D26388-en">NC1_Mission.13: Pour une action tactique de type 15 (DEFENSE), le code symbole doit valoir G*T*GB----***** .</iso:assert>
      <iso:assert test="if (../type=16) then matches(.,':G.T.GX----') else true()" diagnostics="D26389-en">NC1_Mission.13: Pour une action tactique de type 16 (DEGAGEMENT), le code symbole doit valoir G*T*GX----***** .</iso:assert>
      <iso:assert test="if (../type=17) then matches(.,':G.T.GD----') else true()" diagnostics="D26390-en">NC1_Mission.13: Pour une action tactique de type 17 (DESTRUCTION), le code symbole doit valoir G*T*GD----***** .</iso:assert>
      <iso:assert test="if (../type=18) then matches(.,':G.C.MDD---') else true()" diagnostics="D26391-en">NC1_Mission.13: Pour une action tactique de type 18 (DIVERSION), le code symbole doit valoir G*C*MDD---***** .</iso:assert>
      <iso:assert test="if (../type=19) then matches(.,':G.C.MGASS-') else true()" diagnostics="D26392-en">NC1_Mission.13: Pour une action tactique de type 19 (ECLAIRER), le code symbole doit valoir G*C*MGASS-***** .</iso:assert>
      <iso:assert test="if (../type=20) then matches(.,':G.C.MOLR--') else true()" diagnostics="D26393-en">NC1_Mission.13: Pour une action tactique de type 20 (EFFECTUER UN RAID), le code symbole doit valoir G*C*MOLR--***** .</iso:assert>
      <iso:assert test="if (../type=21) then matches(.,':G.T.GZ----') else true()" diagnostics="D26394-en">NC1_Mission.13: Pour une action tactique de type 21 (S'EMPARER), le code symbole doit valoir G*T*GZ----***** .</iso:assert>
      <iso:assert test="if (../type=22) then matches(.,':G.C.MOLAS-') else true()" diagnostics="D26395-en">NC1_Mission.13: Pour une action tactique de type 22 (EXPLOITER), le code symbole doit valoir G*C*MOLAS-***** .</iso:assert>
      <iso:assert test="if (../type=23) then matches(.,':G.T.GSG---') else true()" diagnostics="D26396-en">NC1_Mission.13: Pour une action tactique de type 23 (FLANC GARDER SUR LA DROITE), le code symbole doit valoir G*T*GSG---***** .</iso:assert>
      <iso:assert test="if (../type=24) then matches(.,':G.T.GSG---') else true()" diagnostics="D26397-en">NC1_Mission.13: Pour une action tactique de type 24 (FLANC GARDER SUR LA GAUCHE), le code symbole doit valoir G*T*GSG---***** .</iso:assert>
      <iso:assert test="if (../type=25) then matches(.,':G.T.GF----') else true()" diagnostics="D26398-en">NC1_Mission.13: Pour une action tactique de type 25 (FIXER), le code symbole doit valoir G*T*GF----***** .</iso:assert>
      <iso:assert test="if (../type=26) then matches(.,':G.T.GL----') else true()" diagnostics="D26399-en">NC1_Mission.13: Pour une action tactique de type 26 (FREINAGE), le code symbole doit valoir G*T*GL----***** .</iso:assert>
      <iso:assert test="if (../type=27) then matches(.,':G.C.MSGA--') else true()" diagnostics="D26400-en">NC1_Mission.13: Pour une action tactique de type 27 (HARCELER), le code symbole doit valoir G*C*MSGA--***** .</iso:assert>
      <iso:assert test="if (../type=28) then matches(.,':G.T.GY----') else true()" diagnostics="D26401-en">NC1_Mission.13: Pour une action tactique de type 28 (INFILTRER), le code symbole doit valoir G*T*GY----***** .</iso:assert>
      <iso:assert test="if (../type=29) then matches(.,':G.T.GO----') else true()" diagnostics="D26402-en">NC1_Mission.13: Pour une action tactique de type 29 (INSTALLATION), le code symbole doit valoir G*T*GO----***** .</iso:assert>
      <iso:assert test="if (../type=30) then matches(.,':G.T.GI----') else true()" diagnostics="D26403-en">NC1_Mission.13: Pour une action tactique de type 30 (INTERDIRE), le code symbole doit valoir G*T*GI----***** .</iso:assert>
      <iso:assert test="if (../type=31) then matches(.,':G.C.MSGA--') else true()" diagnostics="D26404-en">NC1_Mission.13: Pour une action tactique de type 31 (INTERCEPTION), le code symbole doit valoir G*C*MSGA--***** .</iso:assert>
      <iso:assert test="if (../type=32) then matches(.,':G.T.GL----') else true()" diagnostics="D26405-en">NC1_Mission.13: Pour une action tactique de type 32 (JALONNER), le code symbole doit valoir G*T*GL----***** .</iso:assert>
      <iso:assert test="if (../type=33) then matches(.,':G.C.MOLAS-') else true()" diagnostics="D26406-en">NC1_Mission.13: Pour une action tactique de type 33 (MARCHER A L'ENNEMI), le code symbole doit valoir G*C*MOLAS-***** .</iso:assert>
      <iso:assert test="if (../type=34) then matches(.,':G.T.GX----') else true()" diagnostics="D26407-en">NC1_Mission.13: Pour une action tactique de type 34 (NETTOYER), le code symbole doit valoir G*T*GX----***** .</iso:assert>
      <iso:assert test="if (../type=35) then matches(.,':G.C.MMDF--') else true()" diagnostics="D26408-en">NC1_Mission.13: Pour une action tactique de type 35 (RECUEILLIR), le code symbole doit valoir G*C*MMDF--***** .</iso:assert>
      <iso:assert test="if (../type=36) then matches(.,':G.C.MGASS-') else true()" diagnostics="D26409-en">NC1_Mission.13: Pour une action tactique de type 36 (RECONNAISSANCE), le code symbole doit valoir G*C*MGASS-***** .</iso:assert>
      <iso:assert test="if (../type=37) then matches(.,':G.T.GD----') else true()" diagnostics="D26410-en">NC1_Mission.13: Pour une action tactique de type 37 (REDUIRE), le code symbole doit valoir G*T*GD----*****.</iso:assert>
      <iso:assert test="if (../type=38) then matches(.,':G.T.GA----') else true()" diagnostics="D26411-en">NC1_Mission.13: Pour une action tactique de type 38 (RELEVE), le code symbole doit valoir G*T*GA----*****.</iso:assert>
      <iso:assert test="if (../type=39) then matches(.,':G.T.GW----') else true()" diagnostics="D26412-en">NC1_Mission.13: Pour une action tactique de type 39 (REPLI), le code symbole doit valoir G*T*GW----***** .</iso:assert>
      <iso:assert test="if (../type=40) then matches(.,':G.T.GB----') else true()" diagnostics="D26413-en">NC1_Mission.13: Pour une action tactique de type 40 (RESISTER), le code symbole doit valoir :G.T.GB----*****.</iso:assert>
      <iso:assert test="if (../type=41) then matches(.,':G.T.GL----') else true()" diagnostics="D26414-en">NC1_Mission.13: Pour une action tactique de type 41 (RETARDER), le code symbole doit valoir G*T*GL----***** .</iso:assert>
      <iso:assert test="if (../type=42) then matches(.,':G.T.GAS---') else true()" diagnostics="D26415-en">NC1_Mission.13: Pour une action tactique de type 42 (SOUTIEN), le code symbole doit valoir G*T*GAS---***** .</iso:assert>
      <iso:assert test="if (../type=43) then matches(.,':G.T.GSS---') else true()" diagnostics="D26416-en">NC1_Mission.13: Pour une action tactique de type 43 (SURVEILLER), le code symbole doit valoir G*T*GSS---***** .</iso:assert>
      <iso:assert test="if (../type=44) then matches(.,':G.T.GQ----') else true()" diagnostics="D26417-en">NC1_Mission.13: Pour une action tactique de type 44 (TENIR), le code symbole doit valoir G*T*GQ----***** .</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Mission.18: Le 4ème caractère du Code symbole de l'action tactique doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/@id">
      <iso:assert test="matches(.,'^54:')" diagnostics="D26368-en">NC1_Mission.6: Le type de l'objet doit avoir pour valeur 54</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/supportMission/areaId/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26369-en">NC1_Mission.7: La zone de la mission d'appui doit être une surface tactique (NC1_TacArea).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/subordinateUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26366-en">NC1_Mission.8: Le subordonné devant réaliser la mission doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26365-en">NC1_Mission.8: Le supérieur donnant la mission doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/superiorParticipantId/@id">
      <iso:assert test="matches(.,'^(9|10|11):')" diagnostics="D26370-en">NC1_Mission.9: Le participant supérieur devant réaliser la mission doit être un participant aérien (NC1_AirParticipant) ou un participant terrestre (NC1_GroundParticipant) ou un participant maritime (NC1_SeaParticipant)</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/subordinateParticipantId/@id">
      <iso:assert test="matches(.,'^(9|10|11):')" diagnostics="D26371-en">NC1_Mission.10: Le participant subordonné devant réaliser la mission doit être un participant aérien (NC1_AirParticipant) ou un participant terrestre (NC1_GroundParticipant) ou un participant maritime (NC1_SeaParticipant)</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/subordinateMissionId/@id">
      <iso:assert test="matches(.,'^54:')" diagnostics="D26372-en">NC1_Mission.11: La mission subordonnée doit être une mission (NC1_Mission)</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/objectiveLocalisedObjectId/@id">
      <iso:assert test="matches(.,'^([0-9]|[1-4][0-9]|51):')" diagnostics="D26367-en">NC1_Mission.12: L'objectif de la mission doit être localisé.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/actionTask">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($MissionFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($MissionSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/type]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26418-en">NC1_Mission.14: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit être celui correspondant à la valeur du dictionnaire des codes symboles APP-6(B) du type de l'action tactique.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then not(type) else type" diagnostics="D26419-en">NC1_Mission.16: Le Type de l'action tactique ne doit être renseigné que si la spécialisation Fr du code symbole ne l'est pas.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/actionTask/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de l'action tactique doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/missionDescription/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de la description de la mission doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1mission:NC1_Mission/tacticalData/supportMission/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de la mission d'appui doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:let name="MissionFrSpecific" value="doc('../Dictionnaires/MissionFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="MissionSymbol" value="doc('../Dictionnaires/MissionSymbolCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26365-en">NC1_Mission.8: The assigning superior shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26366-en">NC1_Mission.8: The mission assigned subordinate unit (NC1_Unit) shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26367-en">NC1_Mission.12: The mission target shall be localized.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26368-en">NC1_Mission.6: The type of the object has to have for value 54</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26369-en">NC1_Mission.7: The zone of the  support mission has to be a tactical surface ( NC1_TacArea).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26370-en">NC1_Mission.9: The participant superior that must realize the mission has to be an air participant ( NC1_AirParticipant) or a ground participant ( NC1_GroundParticipant) or a sea participant ( NC1_SeaParticipant).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26371-en">NC1_Mission.10: The participant subordinated that must realize the mission has to be an air participant ( NC1_AirParticipant) or a ground participant ( NC1_GroundParticipant) or a sea participant ( NC1_SeaParticipant).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26372-en">NC1_Mission.11: The subordinate mission has to be a mission (NC1_Mission)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26373-en">NC1_Mission.5: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26374-en">NC1_Mission.13: The symbol code of a FOLLOW AND SUPPORT action task shall be G*T*GAS---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26375-en">NC1_Mission.13: The symbol code of a MUTUAL SUPPORT action task shall be G*T*GAS---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26376-en">NC1_Mission.13: The symbol code of a ASSAULT action task shall be G*C*MOLAS-***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26377-en">NC1_Mission.13: The symbol code of a ATTACK action task shall be G*C*MOLAS-***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26378-en">NC1_Mission.13: for a 5 (BARRAGE) type tactical task symbol code must be  G*T*GB----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26379-en">NC1_Mission.13: for a 6 (BLOCKING ACTION) type tactical task symbol code must be G*T*GO----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26380-en">NC1_Mission.13: for a 7 (COUNTERATTACK) type tactical task symbol code must be G*T*GK----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26381-en">NC1_Mission.13: for a 8 (COUNTERBATTERY) type tactical task symbol code must be G*T*GKF---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26382-en">NC1_Mission.13: for a 9 (ATTRITION FIGHT) type tactical task symbol code must be G*T*GW----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26383-en">NC1_Mission.13: for a 10 (CONTROL) type tactical task symbol code must be G*T*GO----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26384-en">NC1_Mission.13: for a 11 (COVER) type tactical task symbol code must be G*T*GSC---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26385-en">NC1_Mission.13: for a 12 (CONTACT) type tactical task symbol code must be G*C*MOLAS-***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26386-en">NC1_Mission.13: for a 13 (AREA CONTROL) type tactical task symbol code must be G*T*GS----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26387-en">NC1_Mission.13: for a 14 (DENIAL ACTION) type tactical task symbol code must be G*T*GI----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26388-en">NC1_Mission.13: for a 15 (DEFENSE) type tactical task symbol code must be G*T*GB----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26389-en">NC1_Mission.13: for a 16 (CLEARANCE) type tactical task symbol code must be  G*T*GX----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26390-en">NC1_Mission.13: for a 17 (DESTRUCTION) type tactical task symbol code must be  G*T*GD----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26391-en">NC1_Mission.13: for a 18 (FEINT) type tactical task symbol code must be G*C*MDD---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26392-en">NC1_Mission.13: for a 19 (SCOUT) type tactical task symbol code must be  G*C*MGASS-***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26393-en">NC1_Mission.13: for a 20 (MAKE A RAID) type tactical task symbol code must be  G*C*MOLR--***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26394-en">NC1_Mission.13: for a 21 (SEIZE) type tactical task symbol code must be G*T*GZ----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26395-en">NC1_Mission.13: for a 22 (EXPLOIT) type tactical task symbol code must be  G*C*MOLAS-***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26396-en">NC1_Mission.13: for a 23 (FLANK GUARD ON RIGHT) type tactical task symbol code must be G*T*GSG---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26397-en">NC1_Mission.13: for a 24 (FLANK GUARD ON LEFT) type tactical task symbol code must be G*T*GSG---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26398-en">NC1_Mission.13: for a 25 (FIX) type tactical task symbol code must be G*T*GF----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26399-en">NC1_Mission.13: for a 26 (DELAY) type tactical task symbol code must be  G*T*GL----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26400-en">NC1_Mission.13: for a 27 (HARASS) type tactical task symbol code must be G*C*MSGA--***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26401-en">NC1_Mission.13: for a 28 (INFILTRATE) type tactical task symbol code must be G*T*GY----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26402-en">NC1_Mission.13: for a 29 (INSTALLATION) type tactical task symbol code must be G*T*GO----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26403-en">NC1_Mission.13: for a 30 (DENY) type tactical task symbol code must be G*T*GI----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26404-en">NC1_Mission.13: for a 31 (INTERCEPTION) type tactical task symbol code must be G*C*MSGA--***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26405-en">NC1_Mission.13: for a 32 (RETROGRADE SCREENING ACTION) type tactical task symbol code must be  G*T*GL----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26406-en">NC1_Mission.13: for a 33 (ADVANCE TO CONTACT) type tactical task symbol code must be G*C*MOLAS-***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26407-en">NC1_Mission.13: for a 34 (CLEAR) type tactical task symbol code must be G*T*GX----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26408-en">NC1_Mission.13: for a 35 (ASSIST IN THE REWARD PASSAGE OF LINES) type tactical task symbol code must be G*C*MMDF--***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26409-en">NC1_Mission.13: for a 36 (RECONAISSANCE) type tactical task symbol code must be G*C*MGASS-***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26410-en">NC1_Mission.13: for a 37 (REDUCE) type tactical task symbol code must be G*T*GD----*****.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26411-en">NC1_Mission.13: for a 38 (RELIEF) type tactical task symbol code must be G*T*GA----*****.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26412-en">NC1_Mission.13: for a 39 (RETIREMENT) type tactical task symbol code must be G*T*GW----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26413-en">NC1_Mission.13: for a 40 (RESIST) type tactical task symbol code must be  :G.T.GB----*****.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26414-en">NC1_Mission.13: for a 41 (DELAY) type tactical task symbol code must be G*T*GL----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26415-en">NC1_Mission.13: for a 42 (SUPPORT) type tactical task symbol code must be G*T*GAS---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26416-en">NC1_Mission.13: for a 43 (PERFORM SURVEILLANCE) type tactical task symbol code must be G*T*GSS---***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26417-en">NC1_Mission.13: for a 44 (HOLD) type tactical task symbol code must be G*T*GQ----***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26418-en">NC1_Mission.14: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must be the one corresponding to the value of the dictionary of APP-6 (B) symbol codes of the type tactical action.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26419-en">NC1_Mission.16: The Type of the tactical action must only be filled in if the Fr specialization of the symbol code is not.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>