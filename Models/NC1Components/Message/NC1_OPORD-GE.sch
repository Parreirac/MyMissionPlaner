<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:opordge" prefix="nc1opordge" />
  <iso:pattern>
    <iso:title>NC1_OPORD-GE validation rules</iso:title>
    <iso:rule context="/nc1opordge:NC1_OPORD-GE//mixedText/anyReference/@type">
      <iso:assert test=".=('refObject','localisedPoint','fileLink','datetime')" diagnostics="D26452-en">NC1_OPORD-GE.2: L’attribut « type » est restreint aux valeurs suivantes : 'refObject', 'localisedPoint', 'datetime' et 'fileLink'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1opordge:NC1_OPORD-GE//mixedText/anyReference[@type='refObject']">
      <iso:assert test="count(@id)=1 and count(@datetime)=0 and count(@x)=0 and count(@y)=0 and count(@z)=0 and count(@attachedFile)=0" diagnostics="D26453-en">NC1_OPORD-GE.3: Pour une référence à un objet, seuls les attributs « type », « id » et « instance » peuvent être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1opordge:NC1_OPORD-GE//mixedText/anyReference[@type='datetime']">
      <iso:assert test="count(@id)=0 and count(@instance)=0 and count(@datetime)=1 and count(@x)=0 and count(@y)=0 and count(@z)=0 and count(@attachedFile)=0" diagnostics="D26454-en">NC1_OPORD-GE.4: Pour un groupe date heure, seuls les attributs « type » et « datetime » doivent être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1opordge:NC1_OPORD-GE//mixedText/anyReference[@type='localisedPoint']">
      <iso:assert test="count(@id)=0 and count(@instance)=0 and count(@datetime)=0 and count(@x)=1 and count(@y)=1 and count(@attachedFile)=0" diagnostics="D26455-en">NC1_OPORD-GE.5: Pour un point localisé, seuls les attributs « type », « x », « y » et « z » peuvent être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1opordge:NC1_OPORD-GE//mixedText/anyReference[@type='fileLink']">
      <iso:assert test="count(@id)=0 and count(@instance)=0 and count(@datetime)=0 and count(@x)=0 and count(@y)=0 and count(@z)=0 and count(@attachedFile)=1" diagnostics="D26456-en">NC1_OPORD-GE.6: Pour un lien vers un fichier, seuls les attributs « type » et « attachedFile » doivent être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1opordge:NC1_OPORD-GE//mixedText">
      <iso:assert test="matches(.,'^[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\-\(\)?!@#$%^&amp;*=_+\[\]{}\\&quot;'';&lt;&gt;~|€/:\n\rÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®&#x0009;&#x0060;&#x00A0;&#x0152;&#x0153;&#x2012;&#x2013;&#x2019;&#x2026;]*$')" diagnostics="D26457-en">NC1_OPORD-GE.7: L'un des caractères utilisés n'est pas dans la liste des caractères autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26947-en">NC1_MissionASA.1: L'identifiant de l'unité ASA doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/batteryId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26948-en">NC1_MissionASA.2: L'identifiant de la batterie doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/priorityThreat/penetrationAxis/@id">
      <iso:assert test="matches(.,'^4[12]:')" diagnostics="D26949-en">NC1_MissionASA.4: L'identifiant de la zone particulière doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/implantationArea/airDefenceSectionId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26950-en">NC1_MissionASA.5: L'identifiant de la section ASA doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToDefend/unit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26951-en">NC1_MissionASA.6: L'identifiant de l'unité à défendre doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToDefend/unitHq/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26952-en">NC1_MissionASA.7: L'identifiant du PC de l'unité à défendre doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToEscort/unit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26953-en">NC1_MissionASA.8: L'identifiant de l'unité à escorter doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/unitToEscort/unitHq/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26954-en">NC1_MissionASA.9: L'identifiant du PC de l'unité à escorter doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/specialDefence/elementToDefend/location/@id">
      <iso:assert test="matches(.,'^4[012]:')" diagnostics="D26955-en">NC1_MissionASA.10: L'identifiant de la localisation de l'élément à défendre doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/surveillanceArea/proposedDeploymentArea/@id">
      <iso:assert test="matches(.,'^4[02]:')" diagnostics="D26956-en">NC1_MissionASA.11: L'identifiant de la zone de déploiement proposée doit être soit une surface tactique (NC1_TacArea) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/surveillanceArea/surveillanceArea/area/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26957-en">NC1_MissionASA.12: L'identifiant de la zone de surveillance doit être une surface tactique (NC1_TacArea).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/defenceArea/areaLocation/@id">
      <iso:assert test="matches(.,'^4[012]:')" diagnostics="D26958-en">NC1_MissionASA.13: L'identifiant de la localisation de la zone à défendre doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/tacticalData/airDefenceUnitMission/airDefenceMission/defenceArea/elementToDefend/location/@id">
      <iso:assert test="matches(.,'^4[012]:')" diagnostics="D26959-en">NC1_MissionASA.14: L'identifiant de la localisation de l'élément particulier à défendre doit être soit une surface tactique (NC1_TacArea) ou soit une ligne tactique (NC1_TacLine) ou soit un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASA','MissionASAType')]/@id">
      <iso:assert test="matches(.,'^56:')" diagnostics="D26960-en">NC1_MissionASA.15: Le type de l'objet doit avoir pour valeur 56.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/actionTask/symbolCode">
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
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/@id">
      <iso:assert test="matches(.,'^54:')" diagnostics="D26368-en">NC1_Mission.6: Le type de l'objet doit avoir pour valeur 54</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/supportMission/areaId/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26369-en">NC1_Mission.7: La zone de la mission d'appui doit être une surface tactique (NC1_TacArea).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/subordinateUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26366-en">NC1_Mission.8: Le subordonné devant réaliser la mission doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26365-en">NC1_Mission.8: Le supérieur donnant la mission doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/superiorParticipantId/@id">
      <iso:assert test="matches(.,'^(9|10|11):')" diagnostics="D26370-en">NC1_Mission.9: Le participant supérieur devant réaliser la mission doit être un participant aérien (NC1_AirParticipant) ou un participant terrestre (NC1_GroundParticipant) ou un participant maritime (NC1_SeaParticipant)</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/subordinateParticipantId/@id">
      <iso:assert test="matches(.,'^(9|10|11):')" diagnostics="D26371-en">NC1_Mission.10: Le participant subordonné devant réaliser la mission doit être un participant aérien (NC1_AirParticipant) ou un participant terrestre (NC1_GroundParticipant) ou un participant maritime (NC1_SeaParticipant)</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/subordinateMissionId/@id">
      <iso:assert test="matches(.,'^54:')" diagnostics="D26372-en">NC1_Mission.11: La mission subordonnée doit être une mission (NC1_Mission)</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/objectiveLocalisedObjectId/@id">
      <iso:assert test="matches(.,'^([0-9]|[1-4][0-9]|51):')" diagnostics="D26367-en">NC1_Mission.12: L'objectif de la mission doit être localisé.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/actionTask">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($MissionFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($MissionSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/type]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26418-en">NC1_Mission.14: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit être celui correspondant à la valeur du dictionnaire des codes symboles APP-6(B) du type de l'action tactique.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then not(type) else type" diagnostics="D26419-en">NC1_Mission.16: Le Type de l'action tactique ne doit être renseigné que si la spécialisation Fr du code symbole ne l'est pas.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/actionTask/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de l'action tactique doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/missionDescription/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de la description de la mission doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:mission','MissionType')]/tacticalData/supportMission/dateTime">
      <iso:assert test="qualifier or datetime">NC1_Mission.17: Le qualifiant ou le GDH de l'horodatage de la mission d'appui doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:roe','RoeType')]/@id">
      <iso:assert test="matches(.,'^52:')" diagnostics="D26835-en">NC1_Roe.2: Le type de l'objet doit avoir pour valeur 52</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/executiveUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26961-en">NC1_MissionASS.1: L'identifiant de l'unité exécutante doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/contactFieldArtilleryMission/groundUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26962-en">NC1_MissionASS.2: L'identifiant de l'unité de mêlée doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission/acquiringCOBRA/fireUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26963-en">NC1_MissionASS.3: L'identifiant de l'unité chargée du tir doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission/acquiringCOBRA/registrationFireUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26964-en">NC1_MissionASS.4: L'identifiant de l'unité pour la mise en place doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/contactFieldArtilleryMission/searchedEffect/supportUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26965-en">NC1_MissionASS.5: L'identifiant de l'unité appuyée doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/superiorFieldArtilleryMission">
      <iso:assert test="count(searchedEffect) = count(distinct-values(searchedEffect))" diagnostics="D26966-en">NC1_MissionASS.7: Il ne peut pas y avoir 2 fois le même effet recherché lors de la mission feux du supérieur.</iso:assert>
      <iso:assert test="if (searchedEffect='12') then otherEffect else not(otherEffect)" diagnostics="D26967-en">NC1_MissionASS.8: La description des effets n'est renseignée que si dans la liste des effets recherchés lors de la mission du supérieur il y a la valeur "Autre".</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/contactFieldArtilleryMission/searchedEffect">
      <iso:assert test="if (effectType='12') then otherEffect else not(otherEffect)" diagnostics="D26968-en">NC1_MissionASS.9: La description des effets n'est renseignée que si le type d'effet recherché a la valeur "Autre".</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission/acquiring/target">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26972-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission d'acquisition.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/contactFieldArtilleryMission/priorityTarget">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26970-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission au contact.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/indepthFieldArtilleryMission/priorityTarget">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26971-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission dans la profondeur.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/superiorFieldArtilleryMission/priorityTarget">
      <iso:assert test="if (targetNature='1') then some $x in (1,2,3,4,5,6) satisfies $x=subTargetNature else if (targetNature='2') then some $x in (1,2,3,4,5,7) satisfies $x=subTargetNature else if (targetNature='3') then some $x in (1,2,3,4,5) satisfies $x=subTargetNature else if (targetNature='4') then some $x in (5,11,12,13,14) satisfies $x=subTargetNature else if (targetNature='5') then some $x in (5,15,16,17,18,19) satisfies $x=subTargetNature else if (targetNature='6') then some $x in (5,15,19,20,21,22,23,24,25) satisfies $x=subTargetNature else if (targetNature='7') then some $x in (5,26,27,28,29,30) satisfies $x=subTargetNature else if (targetNature='8') then some $x in (5,31,32,33,34,35) satisfies $x=subTargetNature else if (targetNature='9') then some $x in (1,2,3,4,5,36) satisfies $x=subTargetNature else if (targetNature='10') then some $x in (4,5,37,38,39,40) satisfies $x=subTargetNature else if (targetNature='11') then some $x in (4,5,41,42,43,44,45) satisfies $x=subTargetNature else if (targetNature='12') then some $x in (5,46,47,48,49,50) satisfies $x=subTargetNature else if (targetNature='13') then some $x in (5,51,52,53,54,55,56) satisfies $x=subTargetNature else if (targetNature='14') then some $x in (5,57,58,59,60,61,62) satisfies $x=subTargetNature else if (targetNature='15') then some $x in (5,63,64,65,66) satisfies $x=subTargetNature else if (not(targetNature)) then not(subTargetNature) else true()" diagnostics="D26969-en">NC1_MissionASS.10: La valeur du sous objectif ne correspond pas aux valeurs permises par l'objectif de la mission du supérieur.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/contactFieldArtilleryMission/target/objectiveForces/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26974-en">NC1_MissionASS.12: L'identifiant de l'objectif de type force doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/indepthFieldArtilleryMission/target/objectiveForces/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26973-en">NC1_MissionASS.12: L'identifiant de l'objectif de type force doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/contactFieldArtilleryMission/consumption">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26983-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
      <iso:assert test="if (caliber='0') then some $x in (1,2,3,4,5,6,7,8,22,53) satisfies $x=loadType else if (some $x in (1,2,4,10,12,13) satisfies $x=caliber) then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,53,54,55) satisfies $x=loadType else if (caliber='3') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,55) satisfies $x=loadType else if (some $x in (5,6,7,8,14,16) satisfies $x=caliber) then some $x in (13,14,15,16,17,18,19,20,21,25,26,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52) satisfies $x=loadType else if (caliber='10') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24) satisfies $x=loadType else if (caliber='17') then some $x in (1,2,4,5,6,23) satisfies $x=loadType else if (caliber='11') then some $x in (1,2,3,4,5,7,23,53) satisfies $x=loadType else if (not(caliber)) then not(loadType) else true()" diagnostics="D26977-en">NC1_MissionASS.15: La valeur du type de chargement ne correspond pas aux valeurs permises par la catégorie du calibre pour la mission au contact.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/fireReinforcementMission/allocatedConsumption">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26982-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
      <iso:assert test="if (caliber='0') then some $x in (1,2,3,4,5,6,7,8,22,53) satisfies $x=loadType else if (some $x in (1,2,4,10,12,13) satisfies $x=caliber) then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,53,54,55) satisfies $x=loadType else if (caliber='3') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,55) satisfies $x=loadType else if (some $x in (5,6,7,8,14,16) satisfies $x=caliber) then some $x in (13,14,15,16,17,18,19,20,21,25,26,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52) satisfies $x=loadType else if (caliber='10') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24) satisfies $x=loadType else if (caliber='17') then some $x in (1,2,4,5,6,23) satisfies $x=loadType else if (caliber='11') then some $x in (1,2,3,4,5,7,23,53) satisfies $x=loadType else if (not(caliber)) then not(loadType) else true()" diagnostics="D26976-en">NC1_MissionASS.15: La valeur du type de chargement ne correspond pas aux valeurs permises par la catégorie du calibre pour la mission de renforcement des feux.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/fireReinforcementMission/fireUnitDescription">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26980-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/indepthFieldArtilleryMission/consumption">
      <iso:assert test="if (caliber='18') then otherCaliber else not(otherCaliber)" diagnostics="D26981-en">NC1_MissionASS.14: La donnée Autre calibre n'est renseignée que si la catégorie du calibre a la valeur "Autre".</iso:assert>
      <iso:assert test="if (caliber='0') then some $x in (1,2,3,4,5,6,7,8,22,53) satisfies $x=loadType else if (some $x in (1,2,4,10,12,13) satisfies $x=caliber) then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,53,54,55) satisfies $x=loadType else if (caliber='3') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24,27,28,55) satisfies $x=loadType else if (some $x in (5,6,7,8,14,16) satisfies $x=caliber) then some $x in (13,14,15,16,17,18,19,20,21,25,26,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52) satisfies $x=loadType else if (caliber='10') then some $x in (1,2,3,4,5,6,7,8,9,10,11,12,22,23,24) satisfies $x=loadType else if (caliber='17') then some $x in (1,2,4,5,6,23) satisfies $x=loadType else if (caliber='11') then some $x in (1,2,3,4,5,7,23,53) satisfies $x=loadType else if (not(caliber)) then not(loadType) else true()" diagnostics="D26975-en">NC1_MissionASS.15: La valeur du type de chargement ne correspond pas aux valeurs permises par la catégorie du calibre pour la mission dans la profondeur.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData">
      <iso:assert test="if (indepthFieldArtilleryMission/acquisitionMeans='16') then indepthFieldArtilleryMission/otherAcquisitionMeans else not(indepthFieldArtilleryMission/otherAcquisitionMeans)" diagnostics="D26978-en">NC1_MissionASS.16: La description d'un autre moyen d'acquisition n'est à renseigner que si le moyen d'acquisition de la mission dans la profondeur a la valeur "Autre".</iso:assert>
      <iso:assert test="if (acquiringFieldArtilleryMission or superiorFieldArtilleryMission) then not(comment) else true()" diagnostics="D26986-en">NC1_MissionASS.23: l’attribut "comment" est interdit lorsque "acquiringFieldArtilleryMission» est présent.</iso:assert>
      <iso:assert test="if (superiorFieldArtilleryMission or fireReinforcementMission or intelFieldArtilleryMission) then not(tacticalPhase) else true()" diagnostics="D26990-en">NC1_MissionASS.29: Le temps de manoeuvre ne doit pas être renseigné si la mission du supérieur ou la mission de renforcement feux ou la mission de renseignement est renseignée.</iso:assert>
      <iso:assert test="if (acquiringFieldArtilleryMission) then string-length(missionASSName)&lt;= 8 else true()" diagnostics="D26992-en">NC1_MissionASS.31: Le nom de la mission ne peut pas excéder 8 caractères si la mission d'acquisition est renseignée.</iso:assert>
      <iso:assert test="if (contactFieldArtilleryMission or indepthFieldArtilleryMission or acquiringFieldArtilleryMission/acquiringCOBRA) then levelOfConfirmation else not(levelOfConfirmation)" diagnostics="D26995-en">NC1_MissionASS.36: Le niveau de confirmation doit être renseigné si la mission au contact ou la mission dans la profondeur ou la mission d'acquisition hors COBRA est renseignée.</iso:assert>
      <iso:assert test="if (not(superiorFieldArtilleryMission) and not(acquiringFieldArtilleryMission)) then not(validityPeriod) else true()" diagnostics="D26996-en">NC1_MissionASS.37: La période de validité ne doit pas être renseignée si la mission du supérieur et la mission d'acquisition ne sont pas renseignées.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/intelFieldArtilleryMission/intelTask/searchedFact">
      <iso:assert test="count(observationType) = count(distinct-values(observationType))" diagnostics="D26979-en">NC1_MissionASS.19: Il ne peut pas y avoir 2 fois le même type d'observation au cours d'une action de la mission de renseignement.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/intelFieldArtilleryMission/intelTask/searchedFact/interestedAuthority/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26984-en">NC1_MissionASS.20: L'identifiant de l'autorité intéressée par le fait recherché de la mission de renseignement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/fireReinforcementMission/beneficialUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26985-en">NC1_MissionASS.21: L'identifiant de l'unité bénéficiaire de la mission de renforcement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission">
      <iso:assert test="if (resourcesType!='1' and resourcesType!='10') then acquiring/coordinationUnit else true()" diagnostics="D26987-en">NC1_MissionASS.26: la formation de coordination de la mission d'acquisition est obligatoire si le type de moyen n'a pas la valeur EOP ni la valeur COBRA.</iso:assert>
      <iso:assert test="if (resourcesType='0' or resourcesType='3') then acquiring/rattachmentUnit else not(acquiring/rattachmentUnit)" diagnostics="D26988-en">NC1_MissionASS.27: la formation de rattachement de la mission d'acquisition est obligatoire si le type de moyen a la valeur EO ou EOA sinon elle est interdite.</iso:assert>
      <iso:assert test="if (resourcesType='0' or resourcesType='3' or resourcesType='10') then not(acquiring/target) else acquiring/target" diagnostics="D26989-en">NC1_MissionASS.28: l'objectif de la mission d'acquisition est interdit si le type de moyen a la valeur EO ou EOA ou COBRA sinon il est obligatoire.</iso:assert>
      <iso:assert test="if (resourcesType='10') then acquiringCOBRA else not(acquiringCOBRA)" diagnostics="D26998-en">NC1_MissionASS.39: Si le type de moyen de la mission d'acquisition a la valeur COBRA alors la partie mission d'acquisition COBRA doit être renseignée sinon elle ne doit pas l'être.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/indepthFieldArtilleryMission/effectByArea">
      <iso:assert test="if (searchedEffectType='12') then otherEffect else not(otherEffect)" diagnostics="D26991-en">NC1_MissionASS.30: Si l'effet recherché de la mission feux dans la profondeur a la valeur OTHER alors la donnée Autres effets doit être renseignée sinon elle ne doit pas être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/fireReinforcementMission/fireUnitDescription/unitType">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2) and matches(.,':...[AP]')" diagnostics="D26993-en">NC1_MissionASS.34: les 13ème et 14ème caractères du type d'unité doivent correspondre à une valeur du dictionnaire L105_2Code et le 4ème caractère doit valoir "A" ou "P".</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission/acquiringCOBRA">
      <iso:assert test="if (delegationFireIndicator='true' or delegationFireIndicator=1) then delegationFireNumber else not(delegationFireNumber)" diagnostics="D26994-en">NC1_MissionASS.35: Si l'indicateur pour la délégation de tir de la mission d'acquisition COBRA a la valeur VRAI alors la donnée Nombre de tirs délégués doit être renseignée sinon elle ne doit pas être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission/beneficialUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26997-en">NC1_MissionASS.38: L'identifiant de l'unité bénéficiaire de la mission d'acquisition doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission/acquiring/coordinationUnit/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26999-en">NC1_MissionASS.40: L'identifiant de l'unité de la formation de coordination de la mission d'acquisition doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/acquiringFieldArtilleryMission/acquiring/rattachmentUnit/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D27000-en">NC1_MissionASS.40: L'identifiant de l'unité de la formation de rattachement de la mission d'acquisition doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/@id">
      <iso:assert test="matches(.,'^57:')" diagnostics="D27001-en">NC1_MissionASS.41: Le type de l'objet doit avoir pour valeur 57.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:missionASS','MissionASSType')]/tacticalData/intelFieldArtilleryMission/areaId/@id">
      <iso:assert test="matches(.,'^42:')">NC1_MissionASS.42: L'identifiant de la zone d'effort ou de priorité de la mission de renseignement doit être une surface tactique (NC1_TacArea).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:reinforcement','ReinforcementType')]/@id">
      <iso:assert test="matches(.,'^53:')" diagnostics="D26736-en">NC1_Reinforcement.3: Le type de l'objet doit avoir pour valeur 53</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:reinforcement','ReinforcementType')]/tacticalData/givenUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26732-en">NC1_Reinforcement.4: L'unité donnée en renforcement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:reinforcement','ReinforcementType')]/tacticalData/providingUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26733-en">NC1_Reinforcement.4: L'unité donnant le renforcement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:reinforcement','ReinforcementType')]/tacticalData/reinforcedUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26734-en">NC1_Reinforcement.4: L'unité renforcée doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:reinforcement','ReinforcementType')]/tacticalData/reinforcementId/@id">
      <iso:assert test="matches(.,'^53:')" diagnostics="D26735-en">NC1_Reinforcement.5: Le renforcement de référence doit être un renforcement (objet NC1_Reinforcement).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:reinforcement','ReinforcementType')]/tacticalData/commandRelationshipCategory">
      <iso:assert test="not(.=0 or .=5)">NC1_Reinforcement.6: Le type de subordination tactique ne peut pas prendre les valeurs "COM" et "RATORG".</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fireobjective','FireObjectiveType')]/location/polyline">
      <iso:assert test="count(point) = 2" diagnostics="D26740-en">NC1_FireObjective.1: La forme polyline doit comporter exactement 2 points.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fireobjective','FireObjectiveType')]/@id">
      <iso:assert test="matches(.,'^36:')" diagnostics="D26744-en">NC1_FireObjective.4: Le type de l'objet doit avoir pour valeur 36</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fireobjective','FireObjectiveType')]/tacticalData/targetId/@id">
      <iso:assert test="matches(.,'^([0-9]|[1-2][0-9]|3[018]|4[0124]):')" diagnostics="D26741-en">NC1_FireObjective.5: L'objet NC1 pris pour objectif feux doit être au choix : un point tactique (NC1_TacPoint), une ligne tactique (NC1_TacLine), une surface tactique (NC1_TacArea), un événement (NC1_Event), un événement NRBC (NC1_CbrnEvent), une forme graphique libre (NC1_FreeShape), un itinéraire (NC1_Route), ou tout objet NC1 physique.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fireobjective','FireObjectiveType')]/tacticalData/synchronizedFireId/@id">
      <iso:assert test="matches(.,'^36:')" diagnostics="D26742-en">NC1_FireObjective.6: L'objectif avec lequel une synchronisation est souhaitée doit être un objectif feux (NC1_FireObjective).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fireobjective','FireObjectiveType')]/tacticalData">
      <iso:assert test="if (../@instance='STC') then count(tno)&gt;0 else count(name)+count(tno)&gt;0" diagnostics="D26743-en">NC1_FireObjective.7: L'objectif feux doit être identifié par son TNO (numéro d'objectif) si l'instance de l'objet est Situation Tactique Courante sinon il doit être identifié par son nom ou par son TNO.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect/location/polyline">
      <iso:assert test="count(point) = 2" diagnostics="D26797-en">NC1_Fire.1: La forme polyline doit comporter exactement 2 points.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/@instance">
      <iso:assert test=". = 'STC'" diagnostics="D26818-en">NC1_Fire.2: L'instance de cet objet doit être STC (Situation Tactique Courante).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/@id">
      <iso:assert test="matches(.,'^37:')" diagnostics="D26819-en">NC1_Fire.3: Le type de l'objet doit avoir pour valeur 37</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/actors/executantEntityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26801-en">NC1_Fire.4: Un exécutant intervenant sur un tir doit être une unité (objet NC1_Unit)</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/actors/otherEntityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26799-en">NC1_Fire.4: Un acteur intervenant sur un tir doit être une unité (objet NC1_Unit) ou un participant (objet NC1_Participant).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/actors/requestingEntityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26798-en">NC1_Fire.4: Le demandeur du tir doit être une unité (objet NC1_Unit) ou un participant (objet NC1_Participant).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/actors/responsibleAuthorityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26800-en">NC1_Fire.4: L'autorité responsable du tir doit être une unité (objet NC1_Unit) ou un participant (objet NC1_Participant).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData">
      <iso:assert test="if ((adjustmentFire/controlMethod = '4') or (fireForEffect/controlMethod = '4')) then count(actors/responsibleAuthorityId) &gt; 0 else count(actors/responsibleAuthorityId) = 0" diagnostics="D26802-en">NC1_Fire.5: L'autorité reponsable du tir doit être renseignée si la méthode de contrôle MEP ou EFF est « Au Commandement Autorité », sinon elle ne doit pas être renseignée.</iso:assert>
      <iso:assert test="if (tacticalEffect/requiredEffect=('2','3','4')) then effectDuration else not(effectDuration)" diagnostics="D26813-en">NC1_Fire.10: Si l'effet à obtenir est 2 (Aveugler dans le visible), 3 (Illuminer), ou 4 (Illuminer dans l'IR), alors la durée de l'effet doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/adjustmentFire">
      <iso:assert test="if (controlMethod = ('2', '3')) then period else not(period)" diagnostics="D26804-en">NC1_Fire.6: Un horodatage (période) du tir de mise en place est nécessaire pour les méthodes de contrôle du tir HSO (Heure Sur Objectif) ou HDT (A l'Heure), sinon l'horodatage ne doit pas être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect">
      <iso:assert test="if (controlMethod = ('2', '3')) then period else not(period)" diagnostics="D26803-en">NC1_Fire.6: Un horodatage (période) du tir d'efficacité est nécessaire pour les méthodes de contrôle du tir HSO (Heure Sur Objectif) ou HDT (A l'Heure), sinon l'horodatage ne doit pas être renseigné.</iso:assert>
      <iso:assert test="if (controlMethod = '0') then true() else count(synchronizedFireId)=0" diagnostics="D26811-en">NC1_Fire.7: Si la méthode de contrôle de tir d'efficacité n'est pas 0 (« AMC » A Mon Commandement), alors le tir ne peut pas être synchronisé avec un autre tir.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect/synchronizedFireId/@id">
      <iso:assert test="matches(.,'^37:')" diagnostics="D26817-en">NC1_Fire.8: Le tir avec lequel une synchronisation est souhaitée doit être un tir (NC1_Fire).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/adjustmentFire/adjustmentPoint">
      <iso:assert test="count(z)&gt;0" diagnostics="D26810-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect/location/circle/center">
      <iso:assert test="count(z)&gt;0" diagnostics="D26809-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect/location/point">
      <iso:assert test="count(z)&gt;0" diagnostics="D26808-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect/location/pointsMultiples/point">
      <iso:assert test="count(z)&gt;0" diagnostics="D26806-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect/location/polyline/point">
      <iso:assert test="count(z)&gt;0" diagnostics="D26805-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/fireForEffect/location/rectangle/center">
      <iso:assert test="count(z)&gt;0" diagnostics="D26807-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/ammunitionEffect/requestedAmmunition">
      <iso:assert test="if (type=('1', '3', '4')) then count(../../effectDuration) + count(shotsCount) = 1 else true()" diagnostics="D26812-en">NC1_Fire.10: Si le type de munition demandé est 1 (« Fumigène »), 3(« Eclairante »), ou 4(« Eclairante dans l'IR »), alors soit la durée de l'effet, soit le nombre de coups est renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/tacticalEffect/targetData/targetId/@id">
      <iso:assert test="matches(.,'^36:')" diagnostics="D26814-en">NC1_Fire.11: La cible doit être un objectif feux (NC1_FireObjective).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:fire','FireType')]/callForFireData/ammunitionEffect">
      <iso:assert test="if (requestedAmmunition/type='6') then (count(requestedAmmunition)=1) else true()" diagnostics="D26820-en">NC1_Fire.12: Lorsque la munition demandée est de type 6 (LRU), alors le panachage est impossible.</iso:assert>
      <iso:assert test="if (requestedAmmunition/type='6') then requestedAmmunition/shotsCount&lt;7 else not(surfaceLRU) and requestedAmmunition/triggerMode" diagnostics="D26815-en">NC1_Fire.13: Lorsque la munition demandée est de type 6 (LRU), alors le nombre de coups est limité à 6 ou moins. Lorsque la munition demandée n'est pas de type LRU, le surfacique LRU (ouvert ou fermé) ne doit pas être renseigné mais le mode de déclenchement doit l'être.</iso:assert>
      <iso:assert test="if (count(surfaceLRU)=1) then (requestedAmmunition/shotsCount&gt;1) else true()" diagnostics="D26816-en">NC1_Fire.14: Pour un surfacique LRU le nombre de coups doit être supérieur ou égal à 2.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:acm','AcmWezType')]/@id">
      <iso:assert test="matches(.,'^34:')" diagnostics="D26847-en">NC1_AcmWez.4: Le type de l'objet doit avoir pour valeur 34</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:acm','AcmWezType')]/tacticalData/usageType">
      <iso:assert test="if (../type=6) then . = (92, 15, 12, 10, 46, 110, 45, 52, 53, 47, 54,78) else true()" diagnostics="D26836-en">NC1_AcmWez.5: Si le type de l'ACM vaut 6 (ADAREA) alors son type d'usage doit valoir 92 (ADIZ), 15 (BZ), 12 (BDZ), 10 (WFZ), 46 (HIDACZ), 110 (LMEZ), 45 (LFEZ), 52 (JEZ), 53 (JOA), 47 (HIMEZ), 54 (LOMEZ) ou 78 (SHORAD).</iso:assert>
      <iso:assert test="if (../type=7) then . = (98, 19, 16, 26, 35, 56, 74, 76, 60, 51, 97, 91, 93, 41, 38, 63, 71) else true()" diagnostics="D26837-en">NC1_AcmWez.5: Si le type de l'ACM vaut 7 (ADOA) alors son type d'usage doit valoir 98 (APPCOR), 19 (CCZONE), 16 (CADA), 26 (COZ), 35 (MFEZ), 56 (MMEZ), 74 (SAFES), 76 (SCZ), 60 (MISARC), 51 (ISR), 97 (AOA), 91 (ADAA), 93 (ADZ), 41 (FRAD), 38 (FIRUB), 63 (PIRAZ) ou 71 (RTF).</iso:assert>
      <iso:assert test="if (../type=2) then . = (0, 21, 22, 23, 24, 25, 102, 103, 26, 37, 4, 29, 64, 67, 7, 9, 1, 106, 105, 100, 104) else true()" diagnostics="D26838-en">NC1_AcmWez.5: Si le type de l'ACM vaut 2 (ATCA) alors son type d'usage doit valoir 0 (ARWY), 21 (CLSA), 22 (CLSB), 23 (CLSC), 24 (CLSD), 25 (CLSE), 102 (CLSF), 103 (CLSG), 26 (COZ), 37 (FIR), 4 (TCA), 29 (DA), 64 (PROHIB), 67 (RA), 7 (TRSA), 9 (WARN), 1 (ADVRTE), 106 (CONTZN), 105 (CTA), 100 (NAVRTE), ou 104 (CDR).</iso:assert>
      <iso:assert test="if (../type=5) then . = (84, 99, 72, 11, 82, 79, 83, 3, 59) else true()" diagnostics="D26839-en">NC1_AcmWez.5: Si le type de l'ACM vaut 5 (CORRTE) alors son type d'usage doit valoir 84 (AIRCOR), 99 (AIRRTE), 72 (SAAFR), 11 (TMRR), 82 (TC), 79 (SL), 83 (TR), 3 (SC) ou 59 (MRR).</iso:assert>
      <iso:assert test="if (../type=1) then . = (96, 2, 42, 39, 5, 34, 49, 48, 20, 68, 69, 13, 36, 28, 87, 73) else true()" diagnostics="D26840-en">NC1_AcmWez.5: Si le type de l'ACM vaut 1 (PROC) alors son type d'usage doit valoir 96 (ALTRV), 2 (CL), 42 (FSCL), 39 (FLOT), 5 (TL), 34 (FEBA), 49 (IFFON), 48 (IFFOFF), 20 (CFL), 68 (RFA), 69 (RFL), 13 (BNDRY), 36 (FFA), 28 (DBSL), 87 (ACA), ou 73 (SAFE).</iso:assert>
      <iso:assert test="if (../type=0) then . = (90, 27, 32, 44, 57, 116, 14, 75, 50) else true()" diagnostics="D26841-en">NC1_AcmWez.5: Si le type de l'ACM vaut 0 (REFPT) alors son type d'usage doit valoir 90 (ACP), 27 (CP), 32 (EG), 44 (HG), 57 (MG), 116 (MP), 14 (BULL), 75 (SARDOT) ou 50 (ISP).</iso:assert>
      <iso:assert test="if (../type=3) then . = (85, 94, 31, 55, 61, 86, 30, 65, 66, 8, 6, 77, 80, 18, 17, 70) else true()" diagnostics="D26842-en">NC1_AcmWez.5: Si le type de l'ACM vaut 3 (ROZ) alors son type d'usage doit valoir 85 (AAR), 94 (AEW), 31 (EC), 55 (LZ), 61 (NFA), 86 (ABC), 30 (DZ), 65 (PZ), 66 (RECCE), 8 (UAV), 6 (TRNG), 77 (SEMA), 80 (SOF), 18 (CAS), 17 (CAP) ou 70 (ROA).</iso:assert>
      <iso:assert test="if (../type=4) then . = (88, 89, 43, 62, 33, 40, 81, 95, 58, 61) else true()" diagnostics="D26843-en">NC1_AcmWez.5: Si le type de l'ACM vaut 4 (SUA) alors son type d'usage doit valoir 88 (ASCA), 89 (ACSS), 43 (FACA), 62 (NOFLY), 33 (FARP), 40 (FOL), 81 (SSMS), 95 (ALERTA), 58 (MOA), ou 61 (NFA).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:acm','AcmWezType')]/location/airtrack/segment/maxLevelReference">
      <iso:assert test="if (../minLevelReference = 2) then .=2 else true()" diagnostics="D26846-en">NC1_AcmWez.6: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:acm','AcmWezType')]/location/levels/maxLevelReference">
      <iso:assert test="if (../minLevelReference = 2) then .=2 else true()" diagnostics="D26844-en">NC1_AcmWez.6: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:acm','AcmWezType')]/tacticalData/controlPoint/levels/maxLevelReference">
      <iso:assert test="if (../minLevelReference = 2) then .=2 else true()" diagnostics="D26845-en">NC1_AcmWez.6: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:freeshape','FreeShapeType')]/tacticalData/style/line/type">
      <iso:assert test=". != 0">NC1_FreeShape.1: Le type de la forme libre de style ligne ne peut être égal à 0.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:freeshape','FreeShapeType')]/@id">
      <iso:assert test="matches(.,'^44:')" diagnostics="D26752-en">NC1_FreeShape.4: Le type de l'objet doit avoir pour valeur 44</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:freeshape','FreeShapeType')]/location/point">
      <iso:assert test="not(../../tacticalData/style/line) and not(../../tacticalData/style/area)" diagnostics="D26753-en">NC1_FreeShape.5: Dans le cas où la localisation est un point alors la forme ne peut être ni une ligne ni une zone.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:freeshape','FreeShapeType')]/location">
      <iso:assert test="if (polygon or rectangle or circle or ellipse or arcband or corridor) then not(../tacticalData/style/point) and not(../tacticalData/style/line) else true()">NC1_FreeShape.6: Dans le cas où la localisation est un polygone ou un rectangle ou un cercle ou  une ellipse ou un radarc ou un corridor alors la forme ne peut être ni un point ni une ligne.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:freeshape','FreeShapeType')]/location/polyline">
      <iso:assert test="not(../../tacticalData/style/point) and not(../../tacticalData/style/area)">NC1_FreeShape.7: Dans le cas où la localisation est une polyligne alors la forme ne peut être ni un point ni une zone.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:meteo','MeteoType')]/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:W-A.......-----')" diagnostics="D26939-en">NC1_Meteo.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un objet météo doit être dans la famille W-A*******----- .</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Meteo.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:meteo','MeteoType')]/@id">
      <iso:assert test="matches(.,'^32:')" diagnostics="D26942-en">NC1_Meteo.4: Le type de l'objet doit avoir pour valeur 32</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:meteo','MeteoType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26940-en">NC1_Meteo.5: Lorsqu'il s'agit d'une prévision météo, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:meteo','MeteoType')]/tacticalData">
      <iso:assert test="if (matches(symbolCode, ':...P')) then count(probabilityRatio) = 0 else true()" diagnostics="D26941-en">NC1_Meteo.6: Lorsqu'il s'agit d'une observation ou d'une mesure météo, la probabilité de réalisation du phénomène météo ne doit pas être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:iffprocedure','IffProcedureType')]/@id">
      <iso:assert test="matches(.,'^35:')" diagnostics="D26834-en">NC1_IffProcedure.1: Le type de l'objet doit avoir pour valeur 35</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:iffprocedure','IffProcedureType')]/tacticalData/*/period">
      <iso:assert test="count(duration) &gt; 0" diagnostics="D26833-en">NC1_IffProcedure.2: La durée de la période des codes ou des modes IFF doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:event','EventType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.O')" diagnostics="D26821-en">NC1_Event.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un événement doit être dans la famille G*O************ .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26828-en">NC1_Event.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) = 0 else true()" diagnostics="D26822-en">NC1_Event.6: Lorsque l'événement est anticipé, la qualité de la mesure de localisation ne doit pas être renseignée.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26826-en">NC1_Event.9: La localisation d'un événement ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Event.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:event','EventType')]/@id">
      <iso:assert test="matches(.,'^30:')" diagnostics="D26827-en">NC1_Event.5: Le type de l'objet doit avoir pour valeur 30</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:event','EventType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26825-en">NC1_Event.7: Le responsable de la gestion de l'événement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:event','EventType')]/tacticalData/initiatorEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26823-en">NC1_Event.8: L'acteur ayant provoqué l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:event','EventType')]/tacticalData/involvedEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26824-en">NC1_Event.8: L'acteur impliqué dans l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:route','RouteType')]/location/endPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26856-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26862-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point d'arrivée doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point d'arrivée doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:route','RouteType')]/location/startPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26855-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26861-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point de départ doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point de départ doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:route','RouteType')]/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26860-en">NC1_Route.5: Le type de l'objet doit avoir pour valeur 38</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:route','RouteType')]/location/endTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26858-en">NC1_Route.6: L'identifiant du point d'arrivée de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:route','RouteType')]/location/startTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26857-en">NC1_Route.6: L'identifiant du point de départ de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:route','RouteType')]/location/segment/groundEntityId/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26859-en">NC1_Route.7: L'entité terrain représentant un tronçon d'itinéraire doit être une entité terrain (NC1_GroundEntity).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:cbrnevent','CbrnEventType')]/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:G.C.BW[^D]')" diagnostics="D26794-en">NC1_CbrnEvent.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un événement NRBC doit être dans la famille G*C*BW********* mais pas dans la famille G*C*BWD********</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26796-en">NC1_CbrnEvent.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_CbrnEvent.6: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:cbrnevent','CbrnEventType')]/@id">
      <iso:assert test="matches(.,'^31:')" diagnostics="D26795-en">NC1_CbrnEvent.5: Le type de l'objet doit avoir pour valeur 31</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:3droute','_3DRouteType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.MALC--')" diagnostics="D26943-en">NC1_3DRoute.3: Le standard de symbologie utilisé doit être l'APP-6(B) et le code symbole d'un itinéraire 3D doit être dans la famille G*C*MALC--***** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26946-en">NC1_3DRoute.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:3droute','_3DRouteType')]/@id">
      <iso:assert test="matches(.,'^46:')" diagnostics="D26945-en">NC1_3DRoute.5: Le type de l'objet doit avoir pour valeur 46</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:3droute','_3DRouteType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26944-en">NC1_3DRoute.6: Le responsable de l'itinéraire 3D doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:3droute','_3DRouteType')]/tacticalData">
      <iso:assert test="matches(symbolCode, ':...[AP]')">NC1_3DRoute.7: Le 4ème caractère du Code du symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:3droute','_3DRouteType')]/location/startPoint/timingInstructions">
      <iso:assert test="if (type=0 or type=1) then startDatetime and endDatetime else count(startDatetime) + count(endDatetime) = 1">NC1_3DRoute.8: Si le type de consigne vaut TENIR ou PASSER DANS alors les dates de début et de fin doivent être renseignées sinon une seule date doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:3droute','_3DRouteType')]/location/segment/altitude">
      <iso:assert test="../altitudeReference">NC1_3DRoute.9: La référence de l'altitude doit être renseignée si l'altitude est renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:intelrequirement','IntelRequirementType')]/@id">
      <iso:assert test="matches(.,'^39:')" diagnostics="D26793-en">NC1_IntelRequirement.2: Le type de l'objet doit avoir pour valeur 39</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:intelrequirement','IntelRequirementType')]/location/tacAreaId/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26792-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:intelrequirement','IntelRequirementType')]/location/tacLineId/@id">
      <iso:assert test="matches(.,'^41:')" diagnostics="D26790-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:intelrequirement','IntelRequirementType')]/location/tacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26791-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($ObstacleFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26759-en">NC1_Obstacle.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Obstacle.10: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26754-en">NC1_Obstacle.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) + count(../../location/datetime) = 0 else true()" diagnostics="D26755-en">NC1_Obstacle.5: Lorsque l'obstacle est anticipé, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26760-en">NC1_Obstacle.9: La localisation d'un obstacle ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Obstacle.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/@id">
      <iso:assert test="matches(.,'^17:')" diagnostics="D26761-en">NC1_Obstacle.4: Le type de l'objet doit avoir pour valeur 17</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/number9">
      <iso:assert test="if (matches(../symbolCode, ':.F')) then matches(., '^FR[A-Z0-9]{4}[0-9]{3}') else true()" diagnostics="D26756-en">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ami (2nde lettre du symbolCode = 'F') alors le numéro d'obstacle doit suivre le masque suivant : FR puis alphanumérique sur 4 caractères puis numérique sur 3 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.H')) then matches(., '^ENY [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ennemi (2nde lettre du symbolCode = 'H') alors le numéro d'obstacle doit suivre le masque suivant : 'ENY ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[U]')) then matches(., '^UNK [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle inconnu ami (2nde lettre du symbolCode = 'U') alors le numéro d'obstacle doit suivre le masque suivant : 'UNK ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[FUH]')) then true() else false()">NC1_Obstacle.6: Le symbole code doit représenter soit un obstacle ami (2nde lettre du symbolCode = 'F') soit un obstacle ennemi (2nde lettre du symbolCode = 'H') soit un obstacle inconnu (2nde lettre du symbolCode = 'U').</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/bypassRouteId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26757-en">NC1_Obstacle.7: L'itinéraire de contournement de l'obstacle doit être un objet NC1_Route.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26758-en">NC1_Obstacle.8: L'unité responsable de l'obstacle doit être une unité de l'Ordre de Bataille ami (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($FacilityFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($FacilitySymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26358-en">NC1_Facility.1: Si la spécialisation Fr du code symbole est renseigné alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26364-en">NC1_Facility.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26359-en">NC1_Facility.6: Lorsque l'installation est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26362-en">NC1_Facility.9: La localisation d'une installation ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Facility.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/@id">
      <iso:assert test="matches(.,'^18:')" diagnostics="D26363-en">NC1_Facility.5: Le type de l'objet doit avoir pour valeur 18</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26360-en">NC1_Facility.7: Le responsable de l'installation doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/medicalFacilityData/admittedIndividualId/@id">
      <iso:assert test="matches(.,'^3:')" diagnostics="D26361-en">NC1_Facility.8: La personne admise dans une installation médicale doit être un individu (NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundentity','GroundEntityType')]/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26789-en">NC1_GroundEntity.2: Le type de l'objet doit avoir pour valeur 20</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:G.C.SLC')" diagnostics="D26848-en">NC1_Convoy.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un convoi doit être dans la famille G*C*SLC******** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26854-en">NC1_Convoy.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26849-en">NC1_Convoy.7: Si le convoi est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26852-en">NC1_Convoy.10: La localisation d'un convoi ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Convoy.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/@id">
      <iso:assert test="matches(.,'^16:')" diagnostics="D26853-en">NC1_Convoy.6: Le type de l'objet doit avoir pour valeur 16</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/tacticalData/belongingAgentId/@id">
      <iso:assert test="matches(.,'^[0-8]:')" diagnostics="D26850-en">NC1_Convoy.8: Les membres d'un convoi doivent être des agents (NC1_Unit, NC1_Organisation ou NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/movementData/routeId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26851-en">NC1_Convoy.9: L'itinéraire associé au mouvement doit être un itinéraire (NC1_Route).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S[AF]S')" diagnostics="D26932-en">NC1_SeaParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant maritime doit être dans les familles S*S*******--***. L'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26937-en">NC1_SeaParticipant.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_SeaParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26933-en">NC1_SeaParticipant.5: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/@id">
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
      <iso:assert test="matches(.,'^APP6B:S[AF]A.......--...')" diagnostics="D26925-en">NC1_AirParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant aérien doit être dans les familles S*A*******--*** et l'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26930-en">NC1_AirParticipant.5: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_AirParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26926-en">NC1_AirParticipant.4: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/@id">
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
      <iso:assert test="matches(.,'^APP6B:S[AF]G.E')" diagnostics="D26745-en">NC1_GroundParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant terrestre doit être dans les familles S*G*E*****--***. L'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26750-en">NC1_GroundParticipant.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime)+count(quality) = 0 else true()" diagnostics="D26746-en">NC1_GroundParticipant.5: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/@id">
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
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.(G.E|F.G[^B])')" diagnostics="D26911-en">NC1_GroundTrack.3: Le standard de symbologie utilisé doit être l'APP-6(B). Les familles autorisées par la règle sont : S*G*E*****--*** ou S*F*G*****--*** sauf S*F*GB****--***.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26917-en">NC1_GroundTrack.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26912-en">NC1_GroundTrack.6: Lorsque la piste est anticipée, l'horodatage du relevé de sa position et la qualité de la mesure de localisation sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26914-en">NC1_GroundTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/@id">
      <iso:assert test="matches(.,'^12:')" diagnostics="D26916-en">NC1_GroundTrack.5: Le type de l'objet doit avoir pour valeur 12</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26915-en">NC1_GroundTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26913-en">NC1_GroundTrack.8: L'unité d'appartenance de la piste  doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.A')" diagnostics="D26918-en">NC1_AirTrack.3: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une piste aérienne doit être dans la famille S*A************.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26924-en">NC1_AirTrack.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) + count(../../location/datetime) = 0 else true()" diagnostics="D26919-en">NC1_AirTrack.6: Lorsque la piste est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26921-en">NC1_AirTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_AirTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/@id">
      <iso:assert test="matches(.,'^15:')" diagnostics="D26923-en">NC1_AirTrack.5: Le type de l'objet doit avoir pour valeur 15</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26922-en">NC1_AirTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26920-en">NC1_AirTrack.8: L'unité d'appartenance de la piste doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.S')" diagnostics="D26904-en">NC1_SeaTrack.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une piste maritime doit être dans la famille S*S************.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26910-en">NC1_SeaTrack.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26905-en">NC1_SeaTrack.6: Lorsque la piste est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then(../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26907-en">NC1_SeaTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_SeaTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/@id">
      <iso:assert test="matches(.,'^13:')" diagnostics="D26909-en">NC1_SeaTrack.5: Le type de l'objet doit avoir pour valeur 13</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26908-en">NC1_SeaTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26906-en">NC1_SeaTrack.8: L'unité d'appartenance de la piste doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.MG(AUA|PI)')" diagnostics="D26774-en">NC1_Individual.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un individu doit être dans les familles G*C*MGAUA****** ou G*C*MGPI--***** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26782-en">NC1_Individual.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26775-en">NC1_Individual.6: Lorsque l'individu est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26780-en">NC1_Individual.11: La localisation d'un individu ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Individual.12: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/@id">
      <iso:assert test="matches(.,'^3:')" diagnostics="D26781-en">NC1_Individual.5: Le type de l'objet doit avoir pour valeur 3</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/tacticalData">
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(specialIndicator) = 0 else true()" diagnostics="D26776-en">NC1_Individual.7: Lorsque l'individu est ami (FRIEND ou ASSUMED FRIEND), l'indicateur d'intérêt spécifique ne doit pas être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26777-en">NC1_Individual.8: Le responsable de l'individu ou du groupe d'individus doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/historyItems/historyItem/eventId/@id">
      <iso:assert test="matches(.,'^30:')" diagnostics="D26778-en">NC1_Individual.9: L'objet NC1 relié au fait de main courante doit être un événement (NC1_Event).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/administrativeProperties/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26779-en">NC1_Individual.10: L'unité d'appartenance de l'individu doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:organisation','OrganisationType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.G.(USA|--------..-)')" diagnostics="D26783-en">NC1_Organisation.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une organisation doit être dans les familles S*G*USA******** ou S*G*--------**- .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26788-en">NC1_Organisation.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime)+count(../../location/quality) = 0 else true()" diagnostics="D26784-en">NC1_Organisation.6: Lorsque l'organisation est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26786-en">NC1_Organisation.8: La localisation d'une organisation ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Organisation.9: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:organisation','OrganisationType')]/@id">
      <iso:assert test="matches(.,'^2:')" diagnostics="D26787-en">NC1_Organisation.5: Le type de l'objet doit avoir pour valeur 2</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:organisation','OrganisationType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26785-en">NC1_Organisation.7: Le responsable de l'organisation doit être une unité (NC1_Unit).</iso:assert>
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
    <iso:let name="MissionFrSpecific" value="doc('../Dictionnaires/MissionFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="MissionSymbol" value="doc('../Dictionnaires/MissionSymbolCode.gc')" />
    <iso:let name="ObstacleFrSpecific" value="doc('../Dictionnaires/ObstacleFrSpecificCode.gc')" />
    <iso:let name="ObstacleSymbol" value="doc('../Dictionnaires/ObstacleSymbolCode.gc')" />
    <iso:let name="FacilityFrSpecific" value="doc('../Dictionnaires/FacilityFrSpecificCode.gc')" />
    <iso:let name="FacilitySymbol" value="doc('../Dictionnaires/FacilitySymbolCode.gc')" />
    <iso:let name="UnitFrSpecific" value="doc('../Dictionnaires/UnitFrSpecificCode.gc')" />
    <iso:let name="UnitSymbol" value="doc('../Dictionnaires/UnitSymbolCode.gc')" />
    <iso:let name="TacAreaSymbol" value="doc('../Dictionnaires/TacAreaSymbolCode.gc')" />
    <iso:let name="TacAreaFrSpecific" value="doc('../Dictionnaires/TacAreaFrSpecificCode.gc')" />
    <iso:let name="TacPointSymbol" value="doc('../Dictionnaires/TacPointSymbolCode.gc')" />
    <iso:let name="TacPointFrSpecific" value="doc('../Dictionnaires/TacPointFrSpecificCode.gc')" />
    <iso:let name="TacLineSymbol" value="doc('../Dictionnaires/TacLineSymbolCode.gc')" />
    <iso:let name="TacLineFrSpecific" value="doc('../Dictionnaires/TacLineFrSpecificCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26358-en">NC1_Facility.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26359-en">NC1_Facility.6: When the installation is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26360-en">NC1_Facility.7: The responsible of the 3D route shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26361-en">NC1_Facility.8: The person admitted in a medical installation has to be an individual ( NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26362-en">NC1_Facility.9: The location of the enemy facility shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26363-en">NC1_Facility.5: The type of the object has to have for value 18</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26364-en">NC1_Facility.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
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
    <iso:diagnostic xml:lang="en" id="D26452-en">NC1_OPORD-GE.2: The attribute « type » is restricted to the following values: 'refObject', 'localisedPoint', 'datetime' and  'fileLink'.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26453-en">NC1_OPORD-GE.3: For a reference to an object, only the « type », « id » and «  context »  attributes can be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26454-en">NC1_OPORD-GE.4: For a group date the hour, only the « type » and « datetime »  attributes must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26455-en">NC1_OPORD-GE.5: For a localized point, only the « type », « x », « y » and « z » attributes can be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26456-en">NC1_OPORD-GE.6: For a link towards a file, only the ""type"" and ""url""attributes  must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26457-en">NC1_OPORD-GE.7: One character is not allowed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26732-en">NC1_Reinforcement.4: The reinforcing unit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26733-en">NC1_Reinforcement.4: The unit providing the reinforcement shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26734-en">NC1_Reinforcement.4: The reinforced unit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26735-en">NC1_Reinforcement.5: The reference reinforcement shall be a reinforcement (NC1_Reinforcement).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26736-en">NC1_Reinforcement.3: The type of the object has to have for value 53</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26740-en">NC1_FireObjective.1: The polyline shape must contain exactly 2 points.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26741-en">NC1_FireObjective.5: The possible NC1 object as a fire objective shall be one of the following: a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), an event (NC1_Event), a CBRN event (NC1_CbrnEvent), a free shape (NC1_FreeShape), a route (NC1_Route), or any physical NC1 object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26742-en">NC1_FireObjective.6: The objective with which a synchronization is wished has to be an objective fires (NC1_FireObjective).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26743-en">NC1_FireObjective.7: The objective fires must be identified by its TNO (number of objective) if the context of the object is Current Tactical Situation otherwise he must be identified by his name or by his TNO.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26744-en">NC1_FireObjective.4: The type of the object has to have for value 36</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26745-en">NC1_GroundParticipant.2: The symbology standard to be used shall be APP-6(B). The symbol code of an obstacle shall be of the following type:  S*G*E*****--*** or S*F*******--*** . Participant identity shall be "ASSUMED FRIEND" or "FRIEND" (A or F in APP6B standard)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26746-en">NC1_GroundParticipant.5: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26747-en">NC1_GroundParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26748-en">NC1_GroundParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26749-en">NC1_GroundParticipant.6: The type of the object has to have for value 9</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26750-en">NC1_GroundParticipant.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26751-en">NC1_GroundParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26752-en">NC1_FreeShape.4: The type of the object has to have for value 44</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26753-en">NC1_FreeShape.5: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26754-en">NC1_Obstacle.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26755-en">NC1_Obstacle.5: When the obstacle is anticipated, the quality of the measure of location and the timestamp of the statement of its position on the ground must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26756-en">NC1_Obstacle.6: In the case of an enemy obstacle, that is the identity of which is worth « UNKNOWN », « NEUTRAL », « SUSPECT », « HOSTILE », « JOKER », « FAKER » or « NONE SPECIFIED » (U, N, a Hour, J, K, or O in the APP6B), the number of obstacle on 9 characters has to begin with « ENY ».</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26757-en">NC1_Obstacle.7: The obstacle bypass route shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26758-en">NC1_Obstacle.8: The unit responsible for the obstacle shall be a unit of the Order of Battle (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26759-en">NC1_Obstacle.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26760-en">NC1_Obstacle.9: The location of the enemy obstacle shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26761-en">NC1_Obstacle.4: The type of the object has to have for value 17</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26774-en">NC1_Individual.2: The used standard of symbology has to be the APP-6 (B). The code symbol of an individual has to be in families G*C*MGAUA ****** or G*C*MGPI - ***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26775-en">NC1_Individual.6: When the individual is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26776-en">NC1_Individual.7: For a friendly individual (FRIEND or ASSUMED FRIEND), the SPI indicator shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26777-en">NC1_Individual.8: The responsible of the facility shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26778-en">NC1_Individual.9: The NC1 object linked to the facts register shall be an event (NC1_Event).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26779-en">NC1_Individual.10: The unit the individual belongs to shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26780-en">NC1_Individual.11: The location of the enemy individual shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26781-en">NC1_Individual.5: The type of the object has to have for value 3</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26782-en">NC1_Individual.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26783-en">NC1_Organisation.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of an organization has to be in families S*G*USA ******** or S*G* **--------- .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26784-en">NC1_Organisation.6: When the organization is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26785-en">NC1_Organisation.7: The responsible of the organisation shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26786-en">NC1_Organisation.8: The location of the enemy organisation shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26787-en">NC1_Organisation.5: The type of the object has to have for value 2</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26788-en">NC1_Organisation.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26789-en">NC1_GroundEntity.2: The type of the object has to have for value 20</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26790-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26791-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26792-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26793-en">NC1_IntelRequirement.2: The type of the object has to have for value 39</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26794-en">NC1_CbrnEvent.2: The symbol code of a CBRN event shall be of the following type:  G*C*BW********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26795-en">NC1_CbrnEvent.5: The type of the object has to have for value 31</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26796-en">NC1_CbrnEvent.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26797-en">NC1_Fire.1: The polyline shape must contain exactly 2 points.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26798-en">NC1_Fire.4: The requester of the fire shall be a unit (NC1_Unit) or a participant (NC1_Participant).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26799-en">NC1_Fire.4: Any agent involved in a fire shall be a unit (NC1_Unit object) or a participant (NC1_Participant object).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26800-en">NC1_Fire.4: The responsible authority of the fire shall be a unit (NC1_Unit) or a participant (NC1_Participant).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26801-en">NC1_Fire.4: Any agent involved in a fire shall be a unit (NC1_Unit object)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26802-en">NC1_Fire.5: The reponsable authority of the shooting must be informed if the checking procedure MEP or EFF is « In the Command Authority », otherwise she must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26803-en">NC1_Fire.6: A period or time shall be provided when control method is « TITOTARG » (time to target) or « TITOFIRE » (time to fire).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26804-en">NC1_Fire.6: A period or time shall be provided when control method is « TITOTARG » (time to target) or « TITOFIRE » (time to fire).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26805-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26806-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26807-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26808-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26809-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26810-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26811-en">NC1_Fire.7: If the method of control of shooting of efficiency is not 0 (« AMC » Has My Command), then the shooting cannot be synchronized with another shooting.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26812-en">NC1_Fire.10: If the wanted type of ammunition is 1 (« Smoke »), 3 (« Enlightening »), or 4 (« Enlightening in the IR »), then either the duration of the effect, or the number of blows is informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26813-en">NC1_Fire.10: If the effect to be obtained is 2 (Blind in the visible), 3 (Illuminate), or 4 (Illuminate in the IR), then the duration of the effect must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26814-en">NC1_Fire.11: The target must be a fire objective (NC1_FireObjective).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26815-en">NC1_Fire.13: When the wanted ammunition is type 6 ( LRU), then the number of knocks is limited to 6 or less. When the wanted ammunition is not of type LRU, surface LRU (opened or closed) must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26816-en">NC1_Fire.14: For a MLRS target area, the number of shots shall be at least 2.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26817-en">NC1_Fire.8: The firing with which a synchronization is wished has to be a firing (NC1_Fire).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26818-en">NC1_Fire.2: The object context shall be STC.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26819-en">NC1_Fire.3: The type of the object has to have for value 37</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26820-en">NC1_Fire.12: When the wanted ammunition is type 6 ( LRU), then the mixing is impossible.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26821-en">NC1_Event.2: The used standard of symbology has to be the APP-6 (B). The code symbol of an event has to be in the family G*O ************ .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26822-en">NC1_Event.6: When the event is anticipated, the location measurement quality shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26823-en">NC1_Event.8: The actor having caused the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26824-en">NC1_Event.8: The actor involved in the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26825-en">NC1_Event.7: The responsible of the management of the event shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26826-en">NC1_Event.9: The location of the enemy event shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26827-en">NC1_Event.5: The type of the object has to have for value 30</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26828-en">NC1_Event.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26829-en">NC1_TacPoint.5: The responsible of the tactical point shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26830-en">NC1_TacPoint.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26831-en">NC1_TacPoint.4: The type of the object has to have for value 40</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26832-en">NC1_TacPoint.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26833-en">NC1_IffProcedure.2: The duration of the period of the codes or the modes IFF must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26834-en">NC1_IffProcedure.1: The type of the object has to have for value 35</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26835-en">NC1_Roe.2: The type of the object has to have for value 52</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26836-en">NC1_AcmWez.5: If the type of the ACM is worth 6 ( ADAREA) then his type of use has to be worth 92 ( ADIZ), 15 ( BZ), 12 ( BDZ), 10 ( WFZ), 46 ( HIDACZ), 110 ( LMEZ), 45 ( LFEZ), 52 ( JEZ), 53 ( JOA), 47 ( HIMEZ), 54 ( LOMEZ) or 78 ( SHORAD).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26837-en">NC1_AcmWez.5: If the type of the ACM is worth 7 ( ADOA) then his type of use has to be worth 98 ( APPCOR), 19 ( CCZONE), 16 ( CADA), 26 ( COZ), 35 ( MFEZ), 56 ( MMEZ), 74 ( SAFES), 76 ( SCZ), 60 ( MISARC), 51 ( ISR), 97 ( AOA), 91 ( ADAA), 93 ( ADZ), 41 ( FRAD), 38 ( FIRUB), 63 ( PIRAZ) or 71 (RTF).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26838-en">NC1_AcmWez.5: If the type of the ACM is worth 2 ( ATCA) then his type of use has to be worth 0 ( ARWY), 21 ( CLSA), 22 ( CLSB), 23 ( CLSC), 24 ( CLSD), 25 ( CLSE), 102 ( CLSF), 103 ( CLSG), 26 ( COZ), 37 ( FIR), 4 ( TCA), 29 ( DA), 64 ( PROHIB), 67 ( RA), 7 ( TRSA), 9 ( WARN), 1 ( ADVRTE), 106 ( CONTZN), 105 ( CTA), 100 ( NAVRTE), or 104 (CDR).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26839-en">NC1_AcmWez.5: If the type of the ACM is worth 5 ( CORRTE) then his type of use has to be worth 84 (AIRCOR), 99 ( AIRRTE), 72 ( SAAFR), 11 ( TMRR), 82 ( TC), 79 ( SL), 83 ( TR), 3 ( SC) or 59 ( MRR).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26840-en">NC1_AcmWez.5: If the type of the ACM is worth 1 ( PROC) then his type of use has to be worth 96 ( ALTRV), 2 ( CL), 42 ( FSCL), 39 (FLOT), 5 ( TL), 34 ( FEBA), 49 ( IFFON), 48 ( IFFOFF), 20 ( CFL), 68 (FRG), 69 ( RFL), 13 ( BNDRY), 36 ( FFA), 28 ( DBSL), 87 ( ACA), or 73 ( SAFE).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26841-en">NC1_AcmWez.5: If the type of the ACM is worth 0 (REFPT) then his type of use has to be worth 90 (ACP), 27 (CP), 32 (EG), 44 (HG), 57 (MG), 116 (MP), 14 (BULL), 75 (SARDOT) or 50 (ISP).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26842-en">NC1_AcmWez.5: If the type of the ACM is worth 3 ( ROZ) then his type of use has to be worth 85 ( AAR), 94 ( AEW), 31 ( EC), 55 ( LZ), 61 ( NFA), 86 (ABC), 30 ( DZ), 65 ( PZ), 66 ( RECCE), 8 ( UAV), 6 ( TRNG), 77 (SEMA), 80 ( SOF), 18 (CAS), 17 (CAP) or 70 ( ROA).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26843-en">NC1_AcmWez.5: If the type of the ACM is worth 4 (SUA) then his type of use  has to be worth 88 ( ASCA), 89 ( ACSS), 43 ( FACA), 62 ( NOFLY), 33 ( FARP), 40 (ALERTA), 58 (MOA, or 61 ( NFA).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26844-en">NC1_AcmWez.6: If the reference of minimal height is 2 ( Flight Level), then the reference of maximal height also has to be worth 2 ( Flight Level).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26845-en">NC1_AcmWez.6: If the reference of minimal height is 2 ( Flight Level), then the reference of maximal height also has to be worth 2 ( Flight Level).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26846-en">NC1_AcmWez.6: If the reference of minimal height is 2 ( Flight Level), then the reference of maximal height also has to be worth 2 ( Flight Level).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26847-en">NC1_AcmWez.4: The type of the object has to have for value 34</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26848-en">NC1_Convoy.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a convoy has to be in the family G*C*SLC ******** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26849-en">NC1_Convoy.7: If the convoy is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26850-en">NC1_Convoy.8: The members of a convoy have to be agents (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26851-en">NC1_Convoy.9: The route associated to the movement shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26852-en">NC1_Convoy.10: The location of the enemy convoy shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26853-en">NC1_Convoy.6: The type of the object has to have for value 16</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26854-en">NC1_Convoy.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26855-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26856-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26857-en">NC1_Route.6: The route start point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26858-en">NC1_Route.6: The route end point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26859-en">NC1_Route.7: The ground entity associated to a route section shall be a NC1_GroundEntity object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26860-en">NC1_Route.5: The type of the object has to have for value 38</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26861-en">NC1_Route.4: The 13th and 14th characters of the Code of the starting point symbol must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26862-en">NC1_Route.4: The 13th and 14th characters of the Code of the symbol of the end point must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
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
    <iso:diagnostic xml:lang="en" id="D26939-en">NC1_Meteo.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a meteo object has to be in the family A - W-A-----******* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26940-en">NC1_Meteo.5: When it is about a meteo forecast, the timestamp of the statement of its position on the ground and the quality of the measure of location(localization) must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26941-en">NC1_Meteo.6: For a weather observation or measurement, the probability of the meteorological event occurring shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26942-en">NC1_Meteo.4: The type of the object has to have for value 32</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26943-en">NC1_3DRoute.3: The used standard of symbology has to be the APP-6 ( B ) and the code symbol of a 3D route has to be in the family G*C*MALC - ***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26944-en">NC1_3DRoute.6: The responsible of the facility shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26945-en">NC1_3DRoute.5: The type of the object has to have for value 46</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26946-en">NC1_3DRoute.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26947-en">NC1_MissionASA.1: The ASA unit identifier must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26948-en">NC1_MissionASA.2: Battery ID must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26949-en">NC1_MissionASA.4: The identifier of the particular area must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26950-en">NC1_MissionASA.5: The identifier of the ASA section must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26951-en">NC1_MissionASA.6: The identifier of the unit to be defended must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26952-en">NC1_MissionASA.7: The PC identifier of the unit to be defended must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26953-en">NC1_MissionASA.8: The identifier of the unit to be escorted must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26954-en">NC1_MissionASA.9: The PC identifier of the unit to be escorted must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26955-en">NC1_MissionASA.10: The identifier of the location of the element to be defended must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26956-en">NC1_MissionASA.11: The identifier of the proposed deployment zone must be either a tactical surface (NC1_TacArea) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26957-en">NC1_MissionASA.12: The identifier of the surveillance zone must be a tactical surface (NC1_TacArea).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26958-en">NC1_MissionASA.13: The identifier of the location of the area to be defended must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26959-en">NC1_MissionASA.14: The identifier of the location of the particular element to be defended must be either a tactical surface (NC1_TacArea) or a tactical line (NC1_TacLine) or a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26960-en">NC1_MissionASA.15: The object type must be 56.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26961-en">NC1_MissionASS.1: The identifier of the executing unit must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26962-en">NC1_MissionASS.2: The melee unit identifier must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26963-en">NC1_MissionASS.3: The identifier of the firing unit must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26964-en">NC1_MissionASS.4: The unit identifier for setting up must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26965-en">NC1_MissionASS.5: The identifier of the unit pressed must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26966-en">NC1_MissionASS.7: it's not possible to have the same searched effect in fire mission of superior</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26967-en">NC1_MissionASS.8: effects desscription is filled in only if in sought effect list in superior mission the value "other" is present..</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26968-en">NC1_MissionASS.9: The description of the effects is only filled in if the type of effect sought has the value "Other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26969-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the superior's mission</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26970-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the contact mission</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26971-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the mission in depth</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26972-en">NC1_MissionASS.10: The value of the sub-objective does not correspond to the values ??allowed by the objective of the acquisition mission</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26973-en">NC1_MissionASS.12: The identifier of the force type objective must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26974-en">NC1_MissionASS.12: The identifier of the force type objective must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26975-en">NC1_MissionASS.15: The value of the type of loading does not correspond to the values ??allowed by the category of the caliber for the mission in depth.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26976-en">NC1_MissionASS.15: The value of the load type does not correspond to the values ??allowed by the caliber category for the fire reinforcement mission.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26977-en">NC1_MissionASS.15: The load type value does not correspond to the values ??allowed by the caliber category for the contact mission.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26978-en">NC1_MissionASS.16: The description of another acquisition means must be filled in only if the acquisition means of the deep mission has the value "Other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26979-en">NC1_MissionASS.19: There cannot be twice the same type of observation during an action of the intelligence mission.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26980-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26981-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26982-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26983-en">NC1_MissionASS.14: Other caliber data must be filled in only if the value of category of the caliber is "other".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26984-en">NC1_MissionASS.20: The identifier of the authority interested in the fact sought from the intelligence mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26985-en">NC1_MissionASS.21: The identifier of the beneficiary unit of the reinforcement mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26986-en">NC1_MissionASS.23: attribute "comment" is forbidden when  "acquiringFieldArtilleryMission" is present.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26987-en">NC1_MissionASS.26: the coordination formation of the acquisition mission is mandatory if the type of means does not have the EOP value or the COBRA value.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26988-en">NC1_MissionASS.27: the attachment formation of the acquisition mission is mandatory if the type of means has the value EO or EOA otherwise it is prohibited.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26989-en">NC1_MissionASS.28: the objective of the acquisition mission is prohibited if the type of means has the value EO or EOA or COBRA otherwise it is mandatory.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26990-en">NC1_MissionASS.29: The maneuver time must not be filled in if the superior's mission or the fire reinforcement mission or the intelligence mission is filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26991-en">NC1_MissionASS.30: If the desired effect of the deep fire mission has the value OTHER then the Other effects data item must be filled in otherwise it must not be filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26992-en">NC1_MissionASS.31: The name of the mission cannot exceed 8 characters if the acquisition mission is filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26993-en">NC1_MissionASS.34: the 13th and 14th characters of the unit type must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26994-en">NC1_MissionASS.35: If the indicator for the firing delegation of the COBRA acquisition mission has the value TRUE then the number of delegated firing data must be filled in otherwise it must not be filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26995-en">NC1_MissionASS.36: The confirmation level must be filled in if the contact mission or the in-depth mission or the non-COBRA acquisition mission is filled in.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26996-en">NC1_MissionASS.37: the attachment formation of the acquisition mission is mandatory if the type of means has the value EO or EOA otherwise it is prohibited.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26997-en">NC1_MissionASS.38: The identifier of the beneficiary unit of the acquisition mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26998-en">NC1_MissionASS.39: If the type of means of the acquisition mission has the value COBRA then the COBRA acquisition mission part must be filled in otherwise it must not be.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26999-en">NC1_MissionASS.40: The unit identifier of the acquisition mission coordination formation must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D27000-en">NC1_MissionASS.40: The unit identifier of the formation of the acquisition mission must be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D27001-en">NC1_MissionASS.41: The object type must be 57.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>