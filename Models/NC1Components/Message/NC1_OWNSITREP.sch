<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:ownsitrep" prefix="nc1ownsitrep" />
  <iso:pattern>
    <iso:title>NC1_OWNSITREP validation rules</iso:title>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[UNSHJKO]')" diagnostics="D26583-en">NC1_OWNSITREP.2: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des unités ennemies doit valoir « UNKNOWN », « NEUTRAL », « SUSPECT », « HOSTILE », « JOKER », « FAKER » ou « NONE SPECIFIED » (U, N, S, H, J, K, ou O dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26582-en">NC1_OWNSITREP.2: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des unités amies doit valoir « ASSUMED FRIEND » ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/controlAndCoordinationMeans/coordinationMean/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26586-en">NC1_OWNSITREP.3: Dans le paragraphe « Mesures de coordination 2D », l'identité des moyens de coordination doit valoir « ASSUMED FRIEND » ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/controlAndCoordinationMeans/coordinationMean/@id">
      <iso:assert test="matches(.,'^4[012]:')" diagnostics="D26587-en">NC1_OWNSITREP.4: L'attribut @id du groupe d'attributs « controlAndCoordinationMeans/coordinationMean » doit correspondre à des objets NC1_TacArea, NC1_TacLine ou NC1_TacPoint (classe d'objets 40, 41 ou 42).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/subordinateUnitId">
      <iso:assert test="@id= ../../../friendlyUnit/unit/@id" diagnostics="D26585-en">NC1_OWNSITREP.9: L'unité subordonnée (NC1_Unit) devant réaliser la mission doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/superiorUnitId">
      <iso:assert test="@id= ../../../friendlyUnit/unit/@id" diagnostics="D26584-en">NC1_OWNSITREP.9: Le supérieur (NC1_Unit) donnant la mission doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/unit/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/friendlyUnit/enemyUnit/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/actionTask/symbolCode">
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
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/@id">
      <iso:assert test="matches(.,'^54:')" diagnostics="D26368-en">NC1_Mission.6: Le type de l'objet doit avoir pour valeur 54</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/supportMission/areaId/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26369-en">NC1_Mission.7: La zone de la mission d'appui doit être une surface tactique (NC1_TacArea).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/subordinateUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26366-en">NC1_Mission.8: Le subordonné devant réaliser la mission doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26365-en">NC1_Mission.8: Le supérieur donnant la mission doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/superiorParticipantId/@id">
      <iso:assert test="matches(.,'^(9|10|11):')" diagnostics="D26370-en">NC1_Mission.9: Le participant supérieur devant réaliser la mission doit être un participant aérien (NC1_AirParticipant) ou un participant terrestre (NC1_GroundParticipant) ou un participant maritime (NC1_SeaParticipant)</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/subordinateParticipantId/@id">
      <iso:assert test="matches(.,'^(9|10|11):')" diagnostics="D26371-en">NC1_Mission.10: Le participant subordonné devant réaliser la mission doit être un participant aérien (NC1_AirParticipant) ou un participant terrestre (NC1_GroundParticipant) ou un participant maritime (NC1_SeaParticipant)</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/subordinateMissionId/@id">
      <iso:assert test="matches(.,'^54:')" diagnostics="D26372-en">NC1_Mission.11: La mission subordonnée doit être une mission (NC1_Mission)</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/objectiveLocalisedObjectId/@id">
      <iso:assert test="matches(.,'^([0-9]|[1-4][0-9]|51):')" diagnostics="D26367-en">NC1_Mission.12: L'objectif de la mission doit être localisé.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/actionTask">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($MissionFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($MissionSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/type]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26418-en">NC1_Mission.14: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit être celui correspondant à la valeur du dictionnaire des codes symboles APP-6(B) du type de l'action tactique.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then not(type) else type" diagnostics="D26419-en">NC1_Mission.16: Le Type de l'action tactique ne doit être renseigné que si la spécialisation Fr du code symbole ne l'est pas.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/actionTask/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de l'action tactique doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/missionDescription/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de la description de la mission doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1ownsitrep:NC1_OWNSITREP/ownForcesTaskOrganizationAndPresence/mission/tacticalData/supportMission/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de la mission d'appui doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26588-en">NC1_OWNSITREP.5: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des pistes doit valoir « ASSUMED FRIEND » ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="matches(.,'^APP6B:S.(G.E|F.G[^B])')" diagnostics="D26911-en">NC1_GroundTrack.3: Le standard de symbologie utilisé doit être l'APP-6(B). Les familles autorisées par la règle sont : S*G*E*****--*** ou S*F*G*****--*** sauf S*F*GB****--***.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26917-en">NC1_GroundTrack.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26912-en">NC1_GroundTrack.6: Lorsque la piste est anticipée, l'horodatage du relevé de sa position et la qualité de la mesure de localisation sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26914-en">NC1_GroundTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/@id">
      <iso:assert test="matches(.,'^1[235]:')" diagnostics="D26589-en">NC1_OWNSITREP.6: L'attribut @id du groupe d'attributs « ownForcesTaskOrganizationAndPresence/track » doit correspondre à des objets NC1_AirTrack, NC1_GroundTrack ou NC1_SeaTrack (classe d'objets 12, 13 ou 15).</iso:assert>
      <iso:assert test="matches(.,'^12:')" diagnostics="D26916-en">NC1_GroundTrack.5: Le type de l'objet doit avoir pour valeur 12</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26915-en">NC1_GroundTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26913-en">NC1_GroundTrack.8: L'unité d'appartenance de la piste  doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26588-en">NC1_OWNSITREP.5: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des pistes doit valoir « ASSUMED FRIEND » ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="matches(.,'^APP6B:S.A')" diagnostics="D26918-en">NC1_AirTrack.3: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une piste aérienne doit être dans la famille S*A************.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26924-en">NC1_AirTrack.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) + count(../../location/datetime) = 0 else true()" diagnostics="D26919-en">NC1_AirTrack.6: Lorsque la piste est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26921-en">NC1_AirTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_AirTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/@id">
      <iso:assert test="matches(.,'^1[235]:')" diagnostics="D26589-en">NC1_OWNSITREP.6: L'attribut @id du groupe d'attributs « ownForcesTaskOrganizationAndPresence/track » doit correspondre à des objets NC1_AirTrack, NC1_GroundTrack ou NC1_SeaTrack (classe d'objets 12, 13 ou 15).</iso:assert>
      <iso:assert test="matches(.,'^15:')" diagnostics="D26923-en">NC1_AirTrack.5: Le type de l'objet doit avoir pour valeur 15</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26922-en">NC1_AirTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26920-en">NC1_AirTrack.8: L'unité d'appartenance de la piste doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26588-en">NC1_OWNSITREP.5: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des pistes doit valoir « ASSUMED FRIEND » ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="matches(.,'^APP6B:S.S')" diagnostics="D26904-en">NC1_SeaTrack.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une piste maritime doit être dans la famille S*S************.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26910-en">NC1_SeaTrack.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26905-en">NC1_SeaTrack.6: Lorsque la piste est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then(../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26907-en">NC1_SeaTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_SeaTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/@id">
      <iso:assert test="matches(.,'^1[235]:')" diagnostics="D26589-en">NC1_OWNSITREP.6: L'attribut @id du groupe d'attributs « ownForcesTaskOrganizationAndPresence/track » doit correspondre à des objets NC1_AirTrack, NC1_GroundTrack ou NC1_SeaTrack (classe d'objets 12, 13 ou 15).</iso:assert>
      <iso:assert test="matches(.,'^13:')" diagnostics="D26909-en">NC1_SeaTrack.5: Le type de l'objet doit avoir pour valeur 13</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26908-en">NC1_SeaTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26906-en">NC1_SeaTrack.8: L'unité d'appartenance de la piste doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26590-en">NC1_OWNSITREP.7: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des participant doit valoir « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="matches(.,'^APP6B:S[AF]S')" diagnostics="D26932-en">NC1_SeaParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant maritime doit être dans les familles S*S*******--***. L'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26937-en">NC1_SeaParticipant.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_SeaParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26933-en">NC1_SeaParticipant.5: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/@id">
      <iso:assert test="matches(.,'^9|1[01]:')" diagnostics="D26591-en">NC1_OWNSITREP.8: L'attribut @id du groupe d'attributs « ownForcesTaskOrganizationAndPresence/participant » doit correspondre à des objets NC1_AirParticipant, NC1_GroundParticipant ou NC1_SeaParticipant (classe d'objets 9, 10 ou 11).</iso:assert>
      <iso:assert test="matches(.,'^10:')" diagnostics="D26936-en">NC1_SeaParticipant.6: Le type de l'objet doit avoir pour valeur 10</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26934-en">NC1_SeaParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26935-en">NC1_SeaParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence='true' or presence=1) then idParticipant else true()" diagnostics="D26938-en">NC1_SeaParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^10:')">NC1_SeaParticipant.10: L'identifiant du participant agrégateur doit représenter un participant maritime (la donnée id doit commencer par 10:).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26590-en">NC1_OWNSITREP.7: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des participant doit valoir « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="matches(.,'^APP6B:S[AF]A.......--...')" diagnostics="D26925-en">NC1_AirParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant aérien doit être dans les familles S*A*******--*** et l'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26930-en">NC1_AirParticipant.5: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_AirParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26926-en">NC1_AirParticipant.4: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/@id">
      <iso:assert test="matches(.,'^9|1[01]:')" diagnostics="D26591-en">NC1_OWNSITREP.8: L'attribut @id du groupe d'attributs « ownForcesTaskOrganizationAndPresence/participant » doit correspondre à des objets NC1_AirParticipant, NC1_GroundParticipant ou NC1_SeaParticipant (classe d'objets 9, 10 ou 11).</iso:assert>
      <iso:assert test="matches(.,'^11:')" diagnostics="D26929-en">NC1_AirParticipant.6: Le type de l'objet doit avoir pour valeur 11</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26927-en">NC1_AirParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26928-en">NC1_AirParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence=true()) then idParticipant else true()" diagnostics="D26931-en">NC1_AirParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^11:')">NC1_AirParticipant.10: L'identifiant du participant agrégateur doit représenter un participant aérien (la donnée id doit commencer par 11:).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26590-en">NC1_OWNSITREP.7: Dans le paragraphe « Compte-rendu des unités subordonnées », l'identité des participant doit valoir « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="matches(.,'^APP6B:S[AF]G.E')" diagnostics="D26745-en">NC1_GroundParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant terrestre doit être dans les familles S*G*E*****--***. L'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26750-en">NC1_GroundParticipant.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime)+count(quality) = 0 else true()" diagnostics="D26746-en">NC1_GroundParticipant.5: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/@id">
      <iso:assert test="matches(.,'^9|1[01]:')" diagnostics="D26591-en">NC1_OWNSITREP.8: L'attribut @id du groupe d'attributs « ownForcesTaskOrganizationAndPresence/participant » doit correspondre à des objets NC1_AirParticipant, NC1_GroundParticipant ou NC1_SeaParticipant (classe d'objets 9, 10 ou 11).</iso:assert>
      <iso:assert test="matches(.,'^9:')" diagnostics="D26749-en">NC1_GroundParticipant.6: Le type de l'objet doit avoir pour valeur 9</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26747-en">NC1_GroundParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26748-en">NC1_GroundParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence='true' or presence=1) then idParticipant else true()" diagnostics="D26751-en">NC1_GroundParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^9:')">NC1_GroundParticipant.10: L'identifiant du participant agrégateur doit représenter un participant terrestre (la donnée id doit commencer par 9:).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacarea','TacAreaType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacAreaFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26902-en">NC1_TacArea.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacArea.6: Dans le cas ou la spécialisation Fr du code symbole n'est pas renseigné alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symbole autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacarea','TacAreaType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26900-en">NC1_TacArea.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacArea.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacarea','TacAreaType')]/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26903-en">NC1_TacArea.4: Le type de l'objet doit avoir pour valeur 42.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacarea','TacAreaType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26901-en">NC1_TacArea.5: Le responsable de la surface tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacpoint','TacPointType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacPointFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26830-en">NC1_TacPoint.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacPoint.6: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacpoint','TacPointType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26832-en">NC1_TacPoint.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacPoint.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacpoint','TacPointType')]/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26831-en">NC1_TacPoint.4: Le type de l'objet doit avoir pour valeur 40</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacpoint','TacPointType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26829-en">NC1_TacPoint.5: Le responsable du point tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacline','TacLineType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacLineFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26892-en">NC1_TacLine.3: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacLine.11: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacline','TacLineType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26898-en">NC1_TacLine.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(., ':G.C.MGLB')) then (../../specificData/leftUnitId or ../../specificData/rightUnitId) else true()" diagnostics="D26893-en">NC1_TacLine.7: Si la ligne tactique est une limite entre unités, l'unité à gauche ou l'unité à droite de la limite doit être renseignée sinon aucune ne doit être renseignée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacLine.12: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacline','TacLineType')]/@id">
      <iso:assert test="matches(.,'^41:')" diagnostics="D26897-en">NC1_TacLine.6: Le type de l'objet doit avoir pour valeur 41</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacline','TacLineType')]/specificData/leftUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26894-en">NC1_TacLine.8: L'unité à gauche de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacline','TacLineType')]/specificData/rightUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26895-en">NC1_TacLine.8: L'unité à droite de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacline','TacLineType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26896-en">NC1_TacLine.9: Le responsable de la ligne tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:tacline','TacLineType')]/location/multipoint">
      <iso:assert test="count(point) = 2" diagnostics="D26899-en">NC1_TacLine.10: Le nombre de points pour la localisation de type multipoint est de 2 points.</iso:assert>
    </iso:rule>
    <iso:let name="UnitFrSpecific" value="doc('../Dictionnaires/UnitFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="UnitSymbol" value="doc('../Dictionnaires/UnitSymbolCode.gc')" />
    <iso:let name="MissionFrSpecific" value="doc('../Dictionnaires/MissionFrSpecificCode.gc')" />
    <iso:let name="MissionSymbol" value="doc('../Dictionnaires/MissionSymbolCode.gc')" />
    <iso:let name="TacAreaSymbol" value="doc('../Dictionnaires/TacAreaSymbolCode.gc')" />
    <iso:let name="TacAreaFrSpecific" value="doc('../Dictionnaires/TacAreaFrSpecificCode.gc')" />
    <iso:let name="TacPointSymbol" value="doc('../Dictionnaires/TacPointSymbolCode.gc')" />
    <iso:let name="TacPointFrSpecific" value="doc('../Dictionnaires/TacPointFrSpecificCode.gc')" />
    <iso:let name="TacLineSymbol" value="doc('../Dictionnaires/TacLineSymbolCode.gc')" />
    <iso:let name="TacLineFrSpecific" value="doc('../Dictionnaires/TacLineFrSpecificCode.gc')" />
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
    <iso:diagnostic xml:lang="en" id="D26582-en">NC1_OWNSITREP.2: In the paragraph « Report of the subordinated units », the identity of the friendly units has to be worth « ASSUMED FRIEND » or « FRIEND » (A or F in the APP6B).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26583-en">NC1_OWNSITREP.2: In the paragraph « Report of the subordinated units », the identity of the enemy units has to be worth « UNKNOWN », « NEUTRAL », « SUSPECT », « HOSTILE », « JOKER », « FAKER » or « NONE SPECIFIED » (U, N, a Hour, J, K, or O in the APP6B).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26584-en">NC1_OWNSITREP.9: The mission assigning superior unit (NC1_Unit) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26585-en">NC1_OWNSITREP.9: The mission assigned subordinate unit (NC1_Unit) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26586-en">NC1_OWNSITREP.3: In the paragraph « Measures of 2D coordination », the identity of the ways of coordination has to be worth « ASSUMED FRIEND » or « FRIEND » (A or F in the APP6B).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26587-en">NC1_OWNSITREP.4: The attribute @id of the group of attributes « controlAndCoordinationMeans/coordinationMean » has to correspond to objects NC1_TacArea, NC1_TacLine or NC1_TacPoint (class of objects 40, 41 or 42).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26588-en">NC1_OWNSITREP.5: In the paragraph « Report of the subordinated units », the identity of tracks(runways) has to be worth « ASSUMED FRIEND » or « FRIEND » (In or F in the APP6B).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26589-en">NC1_OWNSITREP.6: The attribute @id of the group of attributes « ownForcesTaskOrganizationAndPresence/track » has to correspond to objects NC1_AirTrack, NC1_GroundTrack or NC1_SeaTrack (class of objects 12, 13 or 15).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26590-en">NC1_OWNSITREP.7: In the paragraph « Report of the subordinated units », the identity of the participating has to be worth « ASSUMED FRIEND », or « FRIEND » (A or F in the APP6B).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26591-en">NC1_OWNSITREP.8: The attribute @id of the group of attributes « ownForcesTaskOrganizationAndPresence/participant » has to correspond to objects NC1_AirParticipant, NC1_GroundParticipant or NC1_SeaParticipant (class of objects 9, 10 ou 11).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26745-en">NC1_GroundParticipant.2: The symbology standard to be used shall be APP-6(B). The symbol code of an obstacle shall be of the following type:  S*G*E*****--*** or S*F*******--*** . Participant identity shall be "ASSUMED FRIEND" or "FRIEND" (A or F in APP6B standard)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26746-en">NC1_GroundParticipant.5: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26747-en">NC1_GroundParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26748-en">NC1_GroundParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26749-en">NC1_GroundParticipant.6: The type of the object has to have for value 9</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26750-en">NC1_GroundParticipant.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26751-en">NC1_GroundParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26829-en">NC1_TacPoint.5: The responsible of the tactical point shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26830-en">NC1_TacPoint.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26831-en">NC1_TacPoint.4: The type of the object has to have for value 40</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26832-en">NC1_TacPoint.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26863-en">NC1_Unit.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26864-en">NC1_Unit.9: When the unity(unit) is anticipated, the quality of the measure of location(localization) and the timestamp of the statement of its position on the ground must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26865-en">NC1_Unit.12: For a link of organic subordination, i.e. equal to 5 (RATORG), the period of detachment should not be informed else the period of detachment must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26866-en">NC1_Unit.13: When the subordination type is provided, the superior unit shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26867-en">NC1_Unit.14: The unit's superior shall also be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26868-en">NC1_Unit.15: The operational or logistic status of the unit shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26869-en">NC1_Unit.2: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26870-en">NC1_Unit.16: The location of the enemy unit shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26871-en">NC1_Unit.8: For a non-friendly unit, only URN and STNL16 IDs shall be provided else only EISN and TNL16 IDs shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26872-en">NC1_Unit.7: The type of the object has to have for value 0</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26873-en">NC1_Unit.19: The "commandAndControlRole" attribute must not have the values ??'Unknown' and 'No statement' for units from DQP.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26892-en">NC1_TacLine.3: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26893-en">NC1_TacLine.7: If the tactical line is a limit between units, unit to the left or unit to the right of the limit shall be provided else none must be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26894-en">NC1_TacLine.8: The unit to the left of the limit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26895-en">NC1_TacLine.8: The unit to the right of the limit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26896-en">NC1_TacLine.9: The responsible of the tactical line shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26897-en">NC1_TacLine.6: The type of the object has to have for value 41</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26898-en">NC1_TacLine.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26899-en">NC1_TacLine.10: The number of points for multipoint type localization is 2 points.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26900-en">NC1_TacArea.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26901-en">NC1_TacArea.5: The responsible of the tactical area shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26902-en">NC1_TacArea.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26903-en">NC1_TacArea.4: The type of the object has to have for value 42</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26904-en">NC1_SeaTrack.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a maritime track has to be in the family S*S ************.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26905-en">NC1_SeaTrack.6: When the track is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26906-en">NC1_SeaTrack.8: The unit the track belongs to shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26907-en">NC1_SeaTrack.9: The location of the enemy track shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26908-en">NC1_SeaTrack.7: The responsible for the handling of the track shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26909-en">NC1_SeaTrack.5: The type of the object has to have for value 13</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26910-en">NC1_SeaTrack.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26911-en">NC1_GroundTrack.3: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a ground track has to be in families S*G*E********** or S*F*G********** except S*F*GB*********.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26912-en">NC1_GroundTrack.6: When the track is anticipated, the timestamp of the statement of its position and the quality of the measure of location on the ground should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26913-en">NC1_GroundTrack.8: The unit the track belongs to shall shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26914-en">NC1_GroundTrack.9: The location of the enemy track shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26915-en">NC1_GroundTrack.7: The responsible for the handling of the track shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26916-en">NC1_GroundTrack.5: The type of the object has to have for value 12</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26917-en">NC1_GroundTrack.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26918-en">NC1_AirTrack.3: The used standard of symbology has to be the APP-6 ( B ). The code symbol of an air track has to be in the family S*A ************.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26919-en">NC1_AirTrack.6: When the track is anticipated, the quality of the measure of location and the timestamp of the statement of its position on the ground should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26920-en">NC1_AirTrack.8: The unit the track belongs to shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26921-en">NC1_AirTrack.9: The location of the enemy track shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26922-en">NC1_AirTrack.7: The responsible for the handling of the track shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26923-en">NC1_AirTrack.5: The type of the object has to have for value 15</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26924-en">NC1_AirTrack.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26925-en">NC1_AirParticipant.2: "The used standard of symbology has to be the APP-6 (B). The code symbol of an air participant has to be in families S*A ******* - *** and the identity of a participant owes ""being ASSUMED FRIEND"", or ""FRIEND"" (In or F in the APP6B)".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26926-en">NC1_AirParticipant.4: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26927-en">NC1_AirParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26928-en">NC1_AirParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26929-en">NC1_AirParticipant.6: The type of the object has to have for value 11</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26930-en">NC1_AirParticipant.5: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26931-en">NC1_AirParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26932-en">NC1_SeaParticipant.2: "The used standard of symbology has to be the APP-6 (B). The code symbol of a maritime participant has to be in families S*S ******* - ***. The identity of a participant owes ""being ASSUMED FRIEND"", or ""FRIEND"" (In or F in the APP6B)".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26933-en">NC1_SeaParticipant.5: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26934-en">NC1_SeaParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26935-en">NC1_SeaParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26936-en">NC1_SeaParticipant.6: The type of the object has to have for value 10</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26937-en">NC1_SeaParticipant.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26938-en">NC1_SeaParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>