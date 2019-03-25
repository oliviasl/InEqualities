//
//  Question4Controller.swift
//  XXHacks
//
//  Created by Stephen Lai on 3/23/19.
//  Copyright © 2019 Olivia Lai. All rights reserved.
//

import Foundation
import UIKit

class Question4Controller: UIViewController {
    
    @IBOutlet weak var question4Answer: UILabel!
    
    @IBOutlet weak var question4Correct: UILabel!
    
    @IBOutlet weak var question4Incorrect: UILabel!
    
    @IBOutlet weak var question4Next: UIButton!
    
    @IBOutlet weak var question4True: UIButton!
    
    @IBOutlet weak var question4False: UIButton!
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        question4Answer.isHidden = true
        question4Correct.isHidden = true
        question4Incorrect.isHidden = true
        question4Next.isHidden = true
        question4True.isHidden = false
        question4False.isHidden = false
        
    }
    
    @IBAction func question4TruePressed(_ sender: Any) {
        
        question4Answer.isHidden = false
        question4Incorrect.isHidden = false
        question4Next.isHidden = false
        question4True.isHidden = true
        question4False.isHidden = true
        
    }
    
    @IBAction func question4FalsePressed(_ sender: Any) {
        
        question4Answer.isHidden = false
        question4Correct.isHidden = false
        question4Next.isHidden = false
        question4True.isHidden = true
        question4False.isHidden = true
        
    }
    
    
    
}

