# Ants

Social Media simulation with agents messaging each other asynchronously. Full task described [here](https://gist.github.com/mihirs16/cf35fe88a13c2df63477f5b33ece7a03).

## Running the experiment

```bash
# syntax
dotnet run [num_ants] [num_messages]

# example
dotnet run 10 100
```

## Sample Experiment Output

```text
> dotnet run 10 100
---------------------------
Spawning a queen...
---------------------------

---------------------------
Spawning 10 ants...
---------------------------
Spawned Stanley43
Spawned Deborah_Abshire
Spawned Joy_Gottlieb92
Spawned Laurence_Schaden
Spawned Jamie.Boyle
Spawned Julie73
Spawned Cary_Bruen
Spawned Whitney.Fadel
Spawned Claudia.Raynor
Spawned Bruce.Daugherty29

---------------------------
Starting ants' behaviour...
---------------------------
From: Whitney.Fadel        | To: Claudia.Raynor       | Message: Voluptas esse et.                                 
From: Cary_Bruen           | To: Claudia.Raynor       | Message: Voluptatum provident consectetur repellendus.     
From: Cary_Bruen           | To: Bruce.Daugherty29    | Message: Sunt et sequi voluptatem.                         
From: Julie73              | To: Laurence_Schaden     | Message: Praesentium quis recusandae nemo voluptatem.      
From: Julie73              | To: Deborah_Abshire      | Message: Minus aliquid repudiandae autem.                  
From: Claudia.Raynor       | To: Cary_Bruen           | Message: Aut et dolores voluptatem.                        
From: Jamie.Boyle          | To: Stanley43            | Message: Veniam saepe dignissimos.                         
From: Bruce.Daugherty29    | To: Jamie.Boyle          | Message: Fuga mollitia qui.                                
From: Julie73              | To: Whitney.Fadel        | Message: Aut doloribus et ipsum error.                     
From: Julie73              | To: Cary_Bruen           | Message: Qui nihil quis enim.                              
From: Stanley43            | To: Deborah_Abshire      | Message: Unde sequi mollitia.                              
From: Deborah_Abshire      | To: Claudia.Raynor       | Message: Quo quibusdam sunt adipisci.                      
From: Joy_Gottlieb92       | To: Whitney.Fadel        | Message: Velit praesentium aut.                            
From: Claudia.Raynor       | To: Jamie.Boyle          | Message: Occaecati deserunt quia aut rerum.                
From: Whitney.Fadel        | To: Jamie.Boyle          | Message: Enim numquam quibusdam doloremque.                
From: Cary_Bruen           | To: Laurence_Schaden     | Message: Qui assumenda fuga autem aut.                     
From: Cary_Bruen           | To: Jamie.Boyle          | Message: Rerum hic dolore praesentium atque.               
From: Laurence_Schaden     | To: Julie73              | Message: Dolores quam voluptatum explicabo reprehenderit.  
From: Joy_Gottlieb92       | To: Julie73              | Message: Expedita et voluptatem occaecati quam.            
From: Cary_Bruen           | To: Joy_Gottlieb92       | Message: Nulla debitis enim.                               
From: Deborah_Abshire      | To: Cary_Bruen           | Message: Vero qui aspernatur.                              
From: Julie73              | To: Joy_Gottlieb92       | Message: Id qui quis.                                      
From: Joy_Gottlieb92       | To: Jamie.Boyle          | Message: Id ea at quibusdam.                               
From: Cary_Bruen           | To: Deborah_Abshire      | Message: Aut error qui magni reprehenderit.                
From: Cary_Bruen           | To: Whitney.Fadel        | Message: Aut saepe corrupti.                               
From: Bruce.Daugherty29    | To: Cary_Bruen           | Message: Similique deleniti dolor possimus ratione.        
From: Stanley43            | To: Laurence_Schaden     | Message: Cupiditate quia omnis perferendis.                
From: Bruce.Daugherty29    | To: Deborah_Abshire      | Message: Iure voluptatem natus in.                         
From: Stanley43            | To: Julie73              | Message: Quia et debitis exercitationem consequatur.       
From: Joy_Gottlieb92       | To: Cary_Bruen           | Message: Sunt eum voluptas.                                
From: Julie73              | To: Jamie.Boyle          | Message: Repellat est et dignissimos.                      
From: Bruce.Daugherty29    | To: Stanley43            | Message: Quod nobis laboriosam explicabo blanditiis.       
From: Jamie.Boyle          | To: Joy_Gottlieb92       | Message: Quia quas rem.                                    
From: Laurence_Schaden     | To: Deborah_Abshire      | Message: Non qui nihil quia deleniti.                      
From: Jamie.Boyle          | To: Julie73              | Message: Vel recusandae hic.                               
From: Cary_Bruen           | To: Stanley43            | Message: Ab aut ex.                                        
From: Cary_Bruen           | To: Stanley43            | Message: Excepturi et et.                                  
From: Stanley43            | To: Bruce.Daugherty29    | Message: Velit sit sed.                                    
From: Joy_Gottlieb92       | To: Laurence_Schaden     | Message: Architecto dolor esse perspiciatis vero.          
From: Deborah_Abshire      | To: Stanley43            | Message: Facilis consectetur odit libero error.            
From: Joy_Gottlieb92       | To: Laurence_Schaden     | Message: Quasi esse nemo vel ut.                           
From: Whitney.Fadel        | To: Stanley43            | Message: Ut nisi vel.                                      
From: Claudia.Raynor       | To: Stanley43            | Message: Ducimus et eius.                                  
From: Bruce.Daugherty29    | To: Deborah_Abshire      | Message: Nihil provident atque voluptatem expedita.        
From: Julie73              | To: Laurence_Schaden     | Message: Ab eveniet aut unde numquam.                      
From: Cary_Bruen           | To: Joy_Gottlieb92       | Message: Eligendi esse rerum praesentium nulla.            
From: Cary_Bruen           | To: Whitney.Fadel        | Message: Dolores porro quia perferendis quod.              
From: Joy_Gottlieb92       | To: Cary_Bruen           | Message: Dignissimos incidunt voluptatem aut dolor.        
From: Laurence_Schaden     | To: Joy_Gottlieb92       | Message: Ut corporis saepe quia delectus.                  
From: Jamie.Boyle          | To: Stanley43            | Message: Ipsa fuga rerum dicta.                            
From: Laurence_Schaden     | To: Stanley43            | Message: Iusto iste in ut.                                 
From: Laurence_Schaden     | To: Joy_Gottlieb92       | Message: Voluptas explicabo ullam.                         
From: Stanley43            | To: Joy_Gottlieb92       | Message: Velit voluptates vel aliquid velit.               
From: Bruce.Daugherty29    | To: Julie73              | Message: Nisi aut aliquid.                                 
From: Whitney.Fadel        | To: Jamie.Boyle          | Message: Laudantium fugiat quasi animi.                    
From: Deborah_Abshire      | To: Whitney.Fadel        | Message: Cum corrupti totam suscipit iusto.                
From: Claudia.Raynor       | To: Cary_Bruen           | Message: Dolores omnis quia sit.                           
From: Whitney.Fadel        | To: Joy_Gottlieb92       | Message: Unde quo in enim tempora.                         
From: Julie73              | To: Cary_Bruen           | Message: Asperiores earum autem.                           
From: Joy_Gottlieb92       | To: Cary_Bruen           | Message: Labore esse velit.                                
From: Deborah_Abshire      | To: Claudia.Raynor       | Message: Nulla eveniet corrupti et.                        
From: Cary_Bruen           | To: Claudia.Raynor       | Message: Animi odio facere dolorem.                        
From: Claudia.Raynor       | To: Deborah_Abshire      | Message: Nihil commodi velit.                              
From: Stanley43            | To: Whitney.Fadel        | Message: Eius velit nulla perspiciatis est.                
From: Cary_Bruen           | To: Deborah_Abshire      | Message: Temporibus dignissimos officia.                   
From: Jamie.Boyle          | To: Bruce.Daugherty29    | Message: Consequatur ut cum.                               
From: Bruce.Daugherty29    | To: Claudia.Raynor       | Message: Ipsa a voluptas fugiat nisi.                      
From: Cary_Bruen           | To: Bruce.Daugherty29    | Message: Blanditiis repellendus dolores dolorum odio.      
From: Laurence_Schaden     | To: Julie73              | Message: Provident numquam libero natus.                   
From: Bruce.Daugherty29    | To: Cary_Bruen           | Message: Dolore eaque dicta.                               
From: Julie73              | To: Jamie.Boyle          | Message: Deserunt molestiae itaque.                        
From: Whitney.Fadel        | To: Laurence_Schaden     | Message: Recusandae unde nesciunt quas praesentium.        
From: Claudia.Raynor       | To: Laurence_Schaden     | Message: Debitis voluptatibus cum.                         
From: Joy_Gottlieb92       | To: Julie73              | Message: Facere in ullam qui.                              
From: Deborah_Abshire      | To: Stanley43            | Message: Ratione doloribus ut maxime nam.                  
From: Laurence_Schaden     | To: Joy_Gottlieb92       | Message: Voluptates iure occaecati.                        
From: Stanley43            | To: Whitney.Fadel        | Message: Consequuntur consequatur repellendus.             
From: Jamie.Boyle          | To: Stanley43            | Message: Rem sunt molestias laborum impedit.               
From: Claudia.Raynor       | To: Deborah_Abshire      | Message: Nam dolores reiciendis voluptas.                  
From: Bruce.Daugherty29    | To: Claudia.Raynor       | Message: Rerum distinctio accusantium amet iure.           
From: Cary_Bruen           | To: Deborah_Abshire      | Message: Assumenda consequatur quo doloribus eos.          
From: Laurence_Schaden     | To: Deborah_Abshire      | Message: Dolorum hic libero.                               
From: Julie73              | To: Stanley43            | Message: Iusto id ea.                                      
From: Deborah_Abshire      | To: Bruce.Daugherty29    | Message: Culpa sunt velit.                                 
From: Whitney.Fadel        | To: Claudia.Raynor       | Message: Recusandae optio a dolorem rerum.                 
From: Stanley43            | To: Laurence_Schaden     | Message: Velit ea placeat sed qui.                         
From: Julie73              | To: Stanley43            | Message: Repudiandae temporibus aliquid dolores sed.       
From: Stanley43            | To: Claudia.Raynor       | Message: Cumque mollitia et qui.                           
From: Stanley43            | To: Deborah_Abshire      | Message: Amet voluptate incidunt omnis.                    
From: Joy_Gottlieb92       | To: Cary_Bruen           | Message: Unde adipisci vel iste officia.                   
From: Jamie.Boyle          | To: Laurence_Schaden     | Message: Est velit laudantium iure officia.                
From: Deborah_Abshire      | To: Cary_Bruen           | Message: Nihil voluptate voluptas quia.                    
From: Cary_Bruen           | To: Laurence_Schaden     | Message: Ducimus nobis est unde.                           
From: Stanley43            | To: Cary_Bruen           | Message: Consectetur commodi suscipit nobis sit.           
From: Deborah_Abshire      | To: Claudia.Raynor       | Message: Expedita enim assumenda est possimus.             
From: Claudia.Raynor       | To: Laurence_Schaden     | Message: Repudiandae ea minima.                            
From: Claudia.Raynor       | To: Jamie.Boyle          | Message: Sed hic numquam cupiditate.                       
From: Bruce.Daugherty29    | To: Stanley43            | Message: Ipsam praesentium at.                             
From: Laurence_Schaden     | To: Deborah_Abshire      | Message: Ratione id dolores.                               
From: Julie73              | To: Jamie.Boyle          | Message: Sint voluptatem autem.                            
Julie73 is done.
Claudia.Raynor is done.
Cary_Bruen is done.
Joy_Gottlieb92 is done.
Jamie.Boyle is done.
Whitney.Fadel is done.
Laurence_Schaden is done.
Stanley43 is done.
Bruce.Daugherty29 is done.
Deborah_Abshire is done.

---------------------------
Displaying stats...
---------------------------
Number of ants: 10
Number of messages: 100

---------------------------
Sent Messages
---------------------------
Whitney.Fadel        | 7    
Cary_Bruen           | 16   
Julie73              | 12   
Claudia.Raynor       | 9    
Jamie.Boyle          | 7    
Bruce.Daugherty29    | 10   
Stanley43            | 11   
Deborah_Abshire      | 9    
Joy_Gottlieb92       | 10   
Laurence_Schaden     | 9    

---------------------------
Received Messages
---------------------------
Claudia.Raynor       | 10    
Bruce.Daugherty29    | 5     
Laurence_Schaden     | 12    
Deborah_Abshire      | 13    
Cary_Bruen           | 13    
Stanley43            | 14    
Jamie.Boyle          | 10    
Whitney.Fadel        | 7     
Julie73              | 7     
Joy_Gottlieb92       | 9     
```
