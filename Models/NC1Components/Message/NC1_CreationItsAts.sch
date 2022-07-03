<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:creationitsats" prefix="nc1creationitsats" />
  <iso:pattern>
    <iso:title>NC1_CreationItsAts validation rules</iso:title>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/tacticalData">
      <iso:assert test="count(status) &gt; 0 and count(otherType) + count(usageType) + count(controlPoint) + count(transitInstructions) + count(broadcastReferencePointName) = 0" diagnostics="D26531-en">NC1_CreationItsAts.2: L'état de mise à jour de l'ITS ou ATS créé doit être renseigné par contre le type de la zone, le type d'usage, le point de contrôle, les instructions de transit et le nom du point de référence ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/tacticalData/status">
      <iso:assert test=". = 1" diagnostics="D26528-en">NC1_CreationItsAts.3: L'état de mise à jour de l'ITS ou ATS doit valoir 1 (CHANGE).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/location">
      <iso:assert test="count(arcband) + count(polyarc) + count(aorbit) = 0" diagnostics="D26529-en">NC1_CreationItsAts.4: Un ITS ou ATS ne doit pas être de forme radarc (arcband), de forme polyarc ou de forme hippodrome (aorbit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/tacticalData/otherUsageType">
      <iso:assert test=". = ('ITS', 'ATS')" diagnostics="D26530-en">NC1_CreationItsAts.5: Le type d'usage d'un ITS ou ATS doit être « ITS » ou « ATS ».</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/@id">
      <iso:assert test="matches(.,'^34:')" diagnostics="D26847-en">NC1_AcmWez.4: Le type de l'objet doit avoir pour valeur 34</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/tacticalData/usageType">
      <iso:assert test="if (../type=6) then . = (92, 15, 12, 10, 46, 110, 45, 52, 53, 47, 54,78) else true()" diagnostics="D26836-en">NC1_AcmWez.5: Si le type de l'ACM vaut 6 (ADAREA) alors son type d'usage doit valoir 92 (ADIZ), 15 (BZ), 12 (BDZ), 10 (WFZ), 46 (HIDACZ), 110 (LMEZ), 45 (LFEZ), 52 (JEZ), 53 (JOA), 47 (HIMEZ), 54 (LOMEZ) ou 78 (SHORAD).</iso:assert>
      <iso:assert test="if (../type=7) then . = (98, 19, 16, 26, 35, 56, 74, 76, 60, 51, 97, 91, 93, 41, 38, 63, 71) else true()" diagnostics="D26837-en">NC1_AcmWez.5: Si le type de l'ACM vaut 7 (ADOA) alors son type d'usage doit valoir 98 (APPCOR), 19 (CCZONE), 16 (CADA), 26 (COZ), 35 (MFEZ), 56 (MMEZ), 74 (SAFES), 76 (SCZ), 60 (MISARC), 51 (ISR), 97 (AOA), 91 (ADAA), 93 (ADZ), 41 (FRAD), 38 (FIRUB), 63 (PIRAZ) ou 71 (RTF).</iso:assert>
      <iso:assert test="if (../type=2) then . = (0, 21, 22, 23, 24, 25, 102, 103, 26, 37, 4, 29, 64, 67, 7, 9, 1, 106, 105, 100, 104) else true()" diagnostics="D26838-en">NC1_AcmWez.5: Si le type de l'ACM vaut 2 (ATCA) alors son type d'usage doit valoir 0 (ARWY), 21 (CLSA), 22 (CLSB), 23 (CLSC), 24 (CLSD), 25 (CLSE), 102 (CLSF), 103 (CLSG), 26 (COZ), 37 (FIR), 4 (TCA), 29 (DA), 64 (PROHIB), 67 (RA), 7 (TRSA), 9 (WARN), 1 (ADVRTE), 106 (CONTZN), 105 (CTA), 100 (NAVRTE), ou 104 (CDR).</iso:assert>
      <iso:assert test="if (../type=5) then . = (84, 99, 72, 11, 82, 79, 83, 3, 59) else true()" diagnostics="D26839-en">NC1_AcmWez.5: Si le type de l'ACM vaut 5 (CORRTE) alors son type d'usage doit valoir 84 (AIRCOR), 99 (AIRRTE), 72 (SAAFR), 11 (TMRR), 82 (TC), 79 (SL), 83 (TR), 3 (SC) ou 59 (MRR).</iso:assert>
      <iso:assert test="if (../type=1) then . = (96, 2, 42, 39, 5, 34, 49, 48, 20, 68, 69, 13, 36, 28, 87, 73) else true()" diagnostics="D26840-en">NC1_AcmWez.5: Si le type de l'ACM vaut 1 (PROC) alors son type d'usage doit valoir 96 (ALTRV), 2 (CL), 42 (FSCL), 39 (FLOT), 5 (TL), 34 (FEBA), 49 (IFFON), 48 (IFFOFF), 20 (CFL), 68 (RFA), 69 (RFL), 13 (BNDRY), 36 (FFA), 28 (DBSL), 87 (ACA), ou 73 (SAFE).</iso:assert>
      <iso:assert test="if (../type=0) then . = (90, 27, 32, 44, 57, 116, 14, 75, 50) else true()" diagnostics="D26841-en">NC1_AcmWez.5: Si le type de l'ACM vaut 0 (REFPT) alors son type d'usage doit valoir 90 (ACP), 27 (CP), 32 (EG), 44 (HG), 57 (MG), 116 (MP), 14 (BULL), 75 (SARDOT) ou 50 (ISP).</iso:assert>
      <iso:assert test="if (../type=3) then . = (85, 94, 31, 55, 61, 86, 30, 65, 66, 8, 6, 77, 80, 18, 17, 70) else true()" diagnostics="D26842-en">NC1_AcmWez.5: Si le type de l'ACM vaut 3 (ROZ) alors son type d'usage doit valoir 85 (AAR), 94 (AEW), 31 (EC), 55 (LZ), 61 (NFA), 86 (ABC), 30 (DZ), 65 (PZ), 66 (RECCE), 8 (UAV), 6 (TRNG), 77 (SEMA), 80 (SOF), 18 (CAS), 17 (CAP) ou 70 (ROA).</iso:assert>
      <iso:assert test="if (../type=4) then . = (88, 89, 43, 62, 33, 40, 81, 95, 58, 61) else true()" diagnostics="D26843-en">NC1_AcmWez.5: Si le type de l'ACM vaut 4 (SUA) alors son type d'usage doit valoir 88 (ASCA), 89 (ACSS), 43 (FACA), 62 (NOFLY), 33 (FARP), 40 (FOL), 81 (SSMS), 95 (ALERTA), 58 (MOA), ou 61 (NFA).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/location/airtrack/segment/maxLevelReference">
      <iso:assert test="if (../minLevelReference = 2) then .=2 else true()" diagnostics="D26846-en">NC1_AcmWez.6: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/location/levels/maxLevelReference">
      <iso:assert test="if (../minLevelReference = 2) then .=2 else true()" diagnostics="D26844-en">NC1_AcmWez.6: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1creationitsats:NC1_CreationItsAts/createdITSorATS/createdITSorATS/tacticalData/controlPoint/levels/maxLevelReference">
      <iso:assert test="if (../minLevelReference = 2) then .=2 else true()" diagnostics="D26845-en">NC1_AcmWez.6: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26528-en">NC1_CreationItsAts.3: The update status of ITS or ATS shall be set to 1 (CHANGE).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26529-en">NC1_CreationItsAts.4: An ITS or ATS does not have to be of shape radarc ( arcband ), of shape polyarc or of shape racecourse ( aorbit ).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26530-en">NC1_CreationItsAts.5: The type of use of an ITS or ATS has to be « ITS » or « ATS ».</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26531-en">NC1_CreationItsAts.2: The state of update of the ITS or created ATS must be informed on the other hand the type of the zone, the type of use, the control point, the instructions of transit and the name of the reference point should not be informed.</iso:diagnostic>
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
  </iso:diagnostics>
</iso:schema>