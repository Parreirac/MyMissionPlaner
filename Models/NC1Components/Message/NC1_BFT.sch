<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:bft" prefix="nc1bft" />
  <iso:pattern>
    <iso:title>NC1_BFT validation rules</iso:title>
    <iso:rule context="/nc1bft:NC1_BFT/@situation">
      <iso:assert test=". = 'STC'" diagnostics="D26726-en">NC1_BFT.1: La situation de ce message doit être STC (Situation Tactique Courante).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1bft:NC1_BFT/locations/participant/@instance">
      <iso:assert test=". = 'STC'" diagnostics="D26730-en">NC1_BFT.2: L'instance des objets inclus dans le message NC1_BFT doit être « STC » (Situation Tactique Courante).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1bft:NC1_BFT/locations/track/@instance">
      <iso:assert test=". = 'STC'" diagnostics="D26731-en">NC1_BFT.2: L'instance des objets inclus dans le message NC1_BFT doit être « STC » (Situation Tactique Courante).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1bft:NC1_BFT/locations/participant">
      <iso:assert test="count(location) &gt; 0" diagnostics="D26728-en">NC1_BFT.4: Tous les participants et les pistes doivent être localisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1bft:NC1_BFT/locations/track">
      <iso:assert test="count(location) &gt; 0" diagnostics="D26727-en">NC1_BFT.4: Tous les participants et les pistes doivent être localisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26729-en">NC1_BFT.5: L'identité des pistes doit valoir « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
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
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26729-en">NC1_BFT.5: L'identité des pistes doit valoir « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
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
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26729-en">NC1_BFT.5: L'identité des pistes doit valoir « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
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
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26726-en">NC1_BFT.1: The context of this message owes being STC (Current Tactical Situation).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26727-en">NC1_BFT.4: All participants and tracks shall include a location.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26728-en">NC1_BFT.4: All participants and tracks shall include a location.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26729-en">NC1_BFT.5: Tracks identity shall be "ASSUMED FRIEND" or "FRIEND" (A or F in APP6B standard).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26730-en">NC1_BFT.2: The context of objects included in the message NC1_BFT has to be « STC » (Current Tactical Situation).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26731-en">NC1_BFT.2: The context of objects included in the message NC1_BFT has to be « STC » (Current Tactical Situation).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26745-en">NC1_GroundParticipant.2: The symbology standard to be used shall be APP-6(B). The symbol code of an obstacle shall be of the following type:  S*G*E*****--*** or S*F*******--*** . Participant identity shall be "ASSUMED FRIEND" or "FRIEND" (A or F in APP6B standard)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26746-en">NC1_GroundParticipant.5: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26747-en">NC1_GroundParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26748-en">NC1_GroundParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26749-en">NC1_GroundParticipant.6: The type of the object has to have for value 9</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26750-en">NC1_GroundParticipant.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26751-en">NC1_GroundParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
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